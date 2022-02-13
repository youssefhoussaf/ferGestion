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
    public partial class print_recu : Form
    {
        public print_recu()
        {
            InitializeComponent();
        }
        public DataTable data;

        private void print_recu_Load(object sender, EventArgs e)
        {
            CrystalReport1 crystal = new CrystalReport1();
            crystal.Database.Tables["printData"].SetDataSource(data);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
