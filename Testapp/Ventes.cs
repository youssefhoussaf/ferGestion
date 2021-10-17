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
                DataTable dt_articles = new DataTable();
                string query = "SELECT v.ID as id_ventes , v.remise as remise," +
                               " a.client as client , v.qte as qte_vente , v.prix as prix_vente," +
                               " v.qte * v.prix as total_vt , (v.prix * v.qte) - (v.prix * v.qte/v.remise) as prix," +
                               " v.created_at as date_creation , a.ID as t_article_id " +
                               "FROM ventes a left join article a on a.ID = v.Article " +
                               "GROUB BY v.ID , v.Article , a.Prix;";
                SqlCommand cmd = new SqlCommand(query, cnx);
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
                MessageBox.Show("Problème de connexion! ");
                frm.Close();
            }
        }
        void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            load();
        }
        private void btn_add_article_Click(object sender, EventArgs e)
        {
            Form addForm = new AddVentes();
            addForm.FormClosing += new FormClosingEventHandler(f_FormClosed);
            addForm.ShowDialog();
        }

        private void Ventes_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
