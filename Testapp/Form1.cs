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
using System.Runtime.InteropServices;

namespace Testapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private SqlConnection cnx = new Connexion().cnx;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            home h = new home();
            h.Dock = DockStyle.Fill;
            container.Controls.Add(h);
        }

        private void btn_home()
        {
            Button btn = new Button();
            btn.Dock = DockStyle.Fill;
            btn.BackColor = Color.FromArgb(52, 52, 76);
            btn.Text = "X";
            Font f = new Font("Arial", 12, FontStyle.Bold);
            btn.Font = f;
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += new EventHandler(btn_home_Click);
            btn_close_cnt.Controls.Add(btn);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            lbl_title.Text = "HOME";
            home h = new home();
            h.Dock = DockStyle.Fill;
            container.Controls.Add(h);
            btn_close_cnt.Controls.Clear();
        }


        private void btn_articles_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Article article = new Article();
            article.Dock = DockStyle.Fill;
            article.frm = this;
            container.Controls.Add(article);
            lbl_title.Text = "ARTICLES";
            btn_home();
        }

        private void btn_ventes_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Ventes vente = new Ventes();
            vente.Dock = DockStyle.Fill;
            vente.frm = this;
            container.Controls.Add(vente);
            lbl_title.Text = "VENTES";
            btn_home();
        }

        private void btn_types_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            types type = new types();
            type.Dock = DockStyle.Fill;
            type.frm = this;
            container.Controls.Add(type);
            lbl_title.Text = "TYPES D'ARTICLES";
            btn_home();
        }

        private void btn_articles_MouseEnter(object sender, EventArgs e)
        {
            btn_articles.BackColor = Color.FromArgb(105, 105, 155);
        }

        private void btn_articles_MouseLeave(object sender, EventArgs e)
        {
            btn_articles.BackColor = Color.FromArgb(52,52,76);
        }

        private void headerBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maxi_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ventes_MouseEnter(object sender, EventArgs e)
        {
            btn_ventes.BackColor = Color.FromArgb(105, 105, 155);
        }

        private void btn_ventes_MouseLeave(object sender, EventArgs e)
        {
            btn_ventes.BackColor = Color.FromArgb(52, 52, 76);
        }

        private void btn_achats_MouseEnter(object sender, EventArgs e)
        {
            btn_achats.BackColor = Color.FromArgb(105, 105, 155);
        }

        private void btn_achats_MouseLeave(object sender, EventArgs e)
        {
            btn_achats.BackColor = Color.FromArgb(52, 52, 76);
        }

        private void btn_types_MouseEnter(object sender, EventArgs e)
        {
            btn_types.BackColor = Color.FromArgb(105, 105, 155);
        }

        private void btn_types_MouseLeave(object sender, EventArgs e)
        {
            btn_types.BackColor = Color.FromArgb(52, 52, 76);
        }

        private void btn_achats_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            achats achat = new achats();
            achat.Dock = DockStyle.Fill;
            achat.frm = this;
            container.Controls.Add(achat);
            lbl_title.Text = "ACHATS";
            btn_home();
        }
    }
}
