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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection cnx = new Connexion().cnx;

        private void load()
        {
            try
            {
                DataTable dt_articles = new DataTable();
                string query = "select * from article";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt_articles.Load(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt_articles;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème de connexion! ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            load();
        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            Form addForm = new AddArticle();
            addForm.FormClosing += new FormClosingEventHandler(f_FormClosed);
            addForm.ShowDialog();

        }
    }
}
