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
                string query = "INSERT INTO article(Article,Prix,StockI,Sortie,StockF) values (@article ,@prix ,@stockI ,@stockS ,@stockA)";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@article", txt_nom.Text);
                cmd.Parameters.AddWithValue("@prix", nub_prix.Value);
                cmd.Parameters.AddWithValue("@stockI", nub_stockI.Value);
                cmd.Parameters.AddWithValue("@stockS", nub_stockS.Value);
                cmd.Parameters.AddWithValue("@stockA", nub_stockA.Value);
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
