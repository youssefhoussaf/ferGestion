using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Testapp
{
    public partial class Article : UserControl
    {
        public Article()
        {
            InitializeComponent();
        }

        public Form1 frm;

        private SqlConnection cnx = new Connexion().cnx;

        private void load()
        {
            try
            {
                DataTable dt_articles = new DataTable();
                string query = "select a.ID , a.Article , a.Prix as 'prix de vente' , (ISNULL(totals.qte,0) - ISNULL(totalsv.qte,0)) + ISNULL(sum(ma.Qte),0) as 'stock I' , ISNULL(sum(mv.Qte),0) as 'sortie' , (ISNULL(totals.qte,0) - ISNULL(totalsv.qte,0)) + ISNULL(sum(ma.Qte),0) - ISNULL(sum(mv.Qte),0) as 'stock F' , a.ID_type from article a left join achats ma on a.ID = ma.Article and ((MONTH(ma.Created_at)=@month and YEAR(ma.Created_at) = @year)) left join ventes mv on a.ID = mv.Article and ((MONTH(mv.Created_at)=@month and YEAR(mv.Created_at) = @year)) left join (select Article , sum(Qte) as 'qte' from achats where MONTH(Created_at)<@month and YEAR(Created_at)<=@year group by Article) as totals on totals.Article = a.ID left join (select Article , sum(Qte) as 'qte' from ventes where MONTH(Created_at)<@month and YEAR(Created_at)<=@year group by Article) as totalsv on totalsv.Article = a.ID group by a.ID , a.Article , a.Prix , a.ID_type , totals.qte , totalsv.qte;";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@year", cmb_annee.SelectedValue);
                cmd.Parameters.AddWithValue("@month", cmb_mois.SelectedValue);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt_articles.Load(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt_articles;
                dataGridView1.Columns[6].Visible = false;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! "+  ex.Message);
                frm.Close();
            }
        }

        void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            load();
        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            Form addForm = new AddArticle();
            addForm.FormClosing += new FormClosingEventHandler(f_FormClosed);
            addForm.StartPosition = FormStartPosition.Manual;
            addForm.Left = frm.Left + (frm.ClientSize.Width / 2) - (addForm.Width / 2);
            addForm.Top = frm.Top + (frm.ClientSize.Height / 2) - (addForm.Height / 2);
            addForm.ShowDialog();
        }

        private void Article_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("name");
            dt.Columns.Add("mois");
            string[] monthNamesFr = { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };
            for (int i = 0; i < monthNamesFr.Length; i++)
            {
                DataRow dt_row = dt.NewRow();
                dt_row["name"] = monthNamesFr[i];
                dt_row["mois"] = i + 1;
                dt.Rows.Add(dt_row);
            }
            cmb_mois.DataSource = dt;
            cmb_mois.ValueMember = "mois";
            cmb_mois.DisplayMember = "name";
            cmb_mois.DropDownStyle = ComboBoxStyle.DropDownList;
            int month = DateTime.Now.Month;
            cmb_mois.SelectedValue = month;
            DataTable dt2 = new DataTable();
            dt2.Clear();
            dt2.Columns.Add("annee");
            for (int i = 0; i < 200; i++)
            {
                DataRow dt_row = dt2.NewRow();
                dt_row["annee"] = 2021 + i;
                dt2.Rows.Add(dt_row);
            }
            cmb_annee.DataSource = dt2;
            cmb_annee.ValueMember = "annee";
            cmb_annee.DisplayMember = "annee";
            cmb_annee.DropDownStyle = ComboBoxStyle.DropDownList;
            int year = DateTime.Now.Year;
            cmb_annee.SelectedValue = year;
            load();
        }

        private void btn_modifier_article_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Merci de selectionne une seule ligne");
            }
            else
            {
                UpdateArticle frmU = new UpdateArticle();
                frmU.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmU.type = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                frmU.prix = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[2].Value);
                frmU.article = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                frmU.FormClosing += new FormClosingEventHandler(f_FormClosed);
                frmU.StartPosition = FormStartPosition.Manual;
                frmU.Left = frm.Left + (frm.ClientSize.Width / 2) - (frmU.Width / 2);
                frmU.Top = frm.Top + (frm.ClientSize.Height / 2) - (frmU.Height / 2);
                frmU.ShowDialog();

            }
        }

        private void btn_delete_article_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Merci de selectionne une ou plusieurs lignes");
            }
            else
            {
                DialogResult dr = MessageBox.Show("voulez-vous vraiment supprimer les articles sélectionnés?", "Supprimer articles", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        try
                        {
                            string query = "delete from article where ID = @id";
                            SqlCommand cmd = new SqlCommand(query, cnx);
                            cmd.Parameters.AddWithValue("@id", id);
                            cnx.Open();
                            cmd.ExecuteNonQuery();
                            cnx.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problème de connexion! "+ ex.Message);
                        }
                    }

                    load();
                }

            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dataGridView1.DataSource;
            dt.DefaultView.RowFilter = string.Format("Article like '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
            dataGridView1.Refresh();
        }
    }
}
