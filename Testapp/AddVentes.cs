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
    public partial class AddVentes : Form
    {
        public AddVentes()
        {
            InitializeComponent();
        }

        private SqlConnection cnx = new Connexion().cnx;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddVentes_Load(object sender, EventArgs e)
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
                string query = "SELECT Prix FROM article WHERE ID = @ID ";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@ID", cmb_articles.SelectedValue);

                string query1 = "INSERT INTO ventes (Client,remise,Article,Qte,Prix,Created_at) values (@Client,@remise,@Article,@Qte,@Prix,CURRENT_TIMESTAMP)";
                SqlCommand cmd1 = new SqlCommand(query1, cnx);
                cnx.Open();
                double prix = Convert.ToDouble(cmd.ExecuteScalar());
                cnx.Close();
                cmd1.Parameters.AddWithValue("@Client", txt_nom.Text);
                cmd1.Parameters.AddWithValue("@remise", remise.Value);
                cmd1.Parameters.AddWithValue("@Article", cmb_articles.SelectedValue);
                cmd1.Parameters.AddWithValue("@Qte", qte.Value);
                cmd1.Parameters.AddWithValue("@prix", prix);

                cnx.Open();
                cmd1.ExecuteNonQuery();
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
