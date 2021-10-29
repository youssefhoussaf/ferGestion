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
    public partial class addAchat : Form
    {
        public addAchat()
        {
            InitializeComponent();
        }

        private SqlConnection cnx = new Connexion().cnx;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addAchat_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_articles = new DataTable();
                string query = "select * from article";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt_articles.Load(dr);
                cmb_articles.DataSource = dt_articles;
                cmb_articles.ValueMember = "ID";
                cmb_articles.DisplayMember = "Article";
                cmb_articles.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_articles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmb_articles.AutoCompleteSource = AutoCompleteSource.ListItems;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! ");
                this.Close();
            }
        }

        private void btn_add_vente_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into achats values(@Fournisseur,@Article,@Qte,@prix,CURRENT_TIMESTAMP);";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Fournisseur", txt_nom.Text);
                cmd.Parameters.AddWithValue("@Article", cmb_articles.SelectedValue);
                cmd.Parameters.AddWithValue("@Qte", qte.Value);
                cmd.Parameters.AddWithValue("@prix", prix.Value);
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
    }
}
