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
    public partial class UpdateArticle : Form
    {
        public UpdateArticle()
        {
            InitializeComponent();
        }

        private SqlConnection cnx = new Connexion().cnx;

        public int id;
        public string article;
        public double prix;
        public int type;

        private void UpdateArticle_Load(object sender, EventArgs e)
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
                cmb_type.SelectedValue = type;
                cmb_type.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_type.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmb_type.AutoCompleteSource = AutoCompleteSource.ListItems;
                txt_nom.Text = article;
                nub_prix.Value = new decimal(prix);
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! ");
                this.Close();
            }
        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE article set Article = @article , Prix = @prix , ID_type = @type where ID = @id";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
