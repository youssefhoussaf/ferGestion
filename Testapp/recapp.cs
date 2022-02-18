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
    public partial class recapp : UserControl
    {
        public recapp()
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
                string query = "select ta.ID , ta.Designation , ISNULL(sum(mv.Prix * mv.Qte),0) as 'Total vente' , ISNULL(sum(mv.Qte),0) as 'Qte' , ((ISNULL(sum(totals.prix),0) - ISNULL(sum(totalsv.prix),0)) + ISNULL(sum(ma.Qte * a.Prix),0)) - ISNULL(sum(a.Prix * mv.Qte),0) as 'Stock Dh' , ISNULL(ISNULL(sum(mv.Prix * mv.Qte),0) - ISNULL(sum(ma.Prix * mv.Qte),0),0) as 'Benifice' from type_article ta inner join article a on ta.ID = a.ID_type left join achats ma on a.ID = ma.Article and ((MONTH(ma.Created_at)=@month and YEAR(ma.Created_at) = @year)) left join ventes mv on a.ID = mv.Article and ((MONTH(mv.Created_at)=@month and YEAR(mv.Created_at) = @year)) left join (select ac.Article , sum(ac.Qte * a.Prix) as 'prix' from achats ac , article a where a.ID = ac.Article and MONTH(ac.Created_at)<@month and YEAR(ac.Created_at)<=@year group by ac.Article) as totals on totals.Article = a.ID left join (select v.Article , sum(v.Qte * a.Prix) as 'prix' from ventes v , article a where v.Article = a.ID and MONTH(v.Created_at)<@month and YEAR(v.Created_at)<=@year group by v.Article) as totalsv on totalsv.Article = a.ID group by ta.ID , ta.Designation;";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@year", cmb_annee.SelectedValue);
                cmd.Parameters.AddWithValue("@month", cmb_mois.SelectedValue);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt_articles.Load(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt_articles;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! " + ex.Message);
                frm.Close();
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void recapp_Load(object sender, EventArgs e)
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
    }
}
