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
    public partial class types : UserControl
    {
        public types()
        {
            InitializeComponent();
        }
        public Form1 frm;

        private SqlConnection cnx = new Connexion().cnx;

        private void load()
        {
            try
            {
                DataTable dt_articles = new DataTable();
                string query = "SELECT * FROM type_article";
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
                MessageBox.Show("Problème de connexion! " + ex.Message);
                frm.Close();
            }
        }
        void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            load();
        }
        private void types_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            if (type_name.Text != "")
            {
                try
                {
                    string query = "INSERT INTO type_article (Designation) values (@designation)";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@designation", type_name.Text);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problème de connexion! ");
                }
            }
            else
            {
                MessageBox.Show("Vous devez remplir le champ désignation...! ");
            }
           
        }


        int id = -1;
        private void btn_modifier_article_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Merci de selectionne une seule ligne");
            }
            else
            {
                try
                {
                    string query = "UPDATE type_article set Designation = @Designation where ID = @id";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Designation", type_name.Text);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    id = -1;
                    type_name.Clear();
                    cnx.Close();
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problème de connexion! ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = -1;
            type_name.Clear();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Merci de selectionne une seule ligne");
                }
                else
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    type_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Merci de selectionne une seule ligne");
                }
                else
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    type_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dataGridView1.DataSource;
            dt.DefaultView.RowFilter = string.Format("Designation like '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
            dataGridView1.Refresh();
        }

        private void Exp_excel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            /*Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();*/
        }
    }
}
