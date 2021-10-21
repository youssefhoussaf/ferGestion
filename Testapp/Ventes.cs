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
    public partial class Ventes : UserControl
    {
        public Ventes()
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
                string query = "SELECT v.ID , v.created_at as 'date' , a.Article , v.Qte , v.Prix as 'P/U' , CONCAT( v.remise,'%') as 'remise' ,  (v.Prix * v.Qte) - (v.Prix * ISNULL(v.Qte/ NULLIF((v.remise),0),0)) as 'total' , v.Client , a.ID as 'article_id' FROM ventes v left join article a on a.ID = v.Article WhERE MONTH(v.Created_at) = @month AND YEAR(v.Created_at) = @year GROUP BY v.ID , v.remise , v.Client  , v.Qte , v.Prix , v.created_at , a.ID , a.Article;";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@year", cmb_annee.SelectedValue);
                cmd.Parameters.AddWithValue("@month", cmb_mois.SelectedValue);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt_articles.Load(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt_articles;
                dataGridView1.Columns[8].Visible = false;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! " + ex.Message);
                frm.Close();
            }
        }
        void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            load();
        }
        private void btn_add_article_Click(object sender, EventArgs e)
        {
        }

        private void Ventes_Load(object sender, EventArgs e)
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

        private void btn_add_article_Click_1(object sender, EventArgs e)
        {
            Form addForm = new AddVentes();
            addForm.FormClosing += new FormClosingEventHandler(f_FormClosed);
            addForm.ShowDialog();
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
                            string query = "delete from ventes where ID = @id";
                            SqlCommand cmd = new SqlCommand(query, cnx);
                            cmd.Parameters.AddWithValue("@id", id);
                            cnx.Open();
                            cmd.ExecuteNonQuery();
                            cnx.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problème de connexion! " + ex.Message);
                        }
                    }

                    load();
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
