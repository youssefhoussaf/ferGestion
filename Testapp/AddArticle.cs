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
    public partial class AddArticle : Form
    {
        public AddArticle()
        {
            InitializeComponent();
        }

        private SqlConnection cnx = new Connexion().cnx;

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO article values (@article,@prix,@type)";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@article", txt_nom.Text);
                cmd.Parameters.AddWithValue("@prix", nub_prix.Value);
                cmd.Parameters.AddWithValue("@type", cmb_type.SelectedValue);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddArticle_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_articles = new DataTable();
                string query = "select * from type_article";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt_articles.Load(dr);
                cmb_type.DataSource = dt_articles;
                cmb_type.ValueMember = "ID";
                cmb_type.DisplayMember = "Designation";
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! ");
                this.Close();
            }
        }
    }
}
