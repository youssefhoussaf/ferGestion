using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testapp
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point((panel1.Parent.ClientSize.Width / 2) - (panel1.Width / 2), (panel1.Parent.ClientSize.Height / 2) - (panel1.Height / 2));
            panel1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
