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

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void btn_articles_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.Dock = DockStyle.Fill;
            article.frm = this;
            container.Controls.Add(article);
        }
    }
}
