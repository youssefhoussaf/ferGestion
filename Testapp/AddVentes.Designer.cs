
namespace Testapp
{
    partial class AddVentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add_vente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.qte = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.remise = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_articles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remise)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_vente
            // 
            this.btn_add_vente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_add_vente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_vente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_vente.ForeColor = System.Drawing.Color.Black;
            this.btn_add_vente.Location = new System.Drawing.Point(617, 323);
            this.btn_add_vente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_vente.Name = "btn_add_vente";
            this.btn_add_vente.Size = new System.Drawing.Size(160, 54);
            this.btn_add_vente.TabIndex = 21;
            this.btn_add_vente.Text = "Ajouter";
            this.btn_add_vente.UseVisualStyleBackColor = false;
            this.btn_add_vente.Click += new System.EventHandler(this.btn_add_vente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom client :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(282, 127);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(493, 22);
            this.txt_nom.TabIndex = 16;
            // 
            // qte
            // 
            this.qte.DecimalPlaces = 2;
            this.qte.Location = new System.Drawing.Point(282, 209);
            this.qte.Margin = new System.Windows.Forms.Padding(4);
            this.qte.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(495, 22);
            this.qte.TabIndex = 24;
            this.qte.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Qté :";
            // 
            // remise
            // 
            this.remise.DecimalPlaces = 2;
            this.remise.Location = new System.Drawing.Point(282, 252);
            this.remise.Margin = new System.Windows.Forms.Padding(4);
            this.remise.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.remise.Name = "remise";
            this.remise.Size = new System.Drawing.Size(495, 22);
            this.remise.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Remise : ";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(888, 51);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ajouter des ventes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Article :";
            // 
            // cmb_articles
            // 
            this.cmb_articles.FormattingEnabled = true;
            this.cmb_articles.Location = new System.Drawing.Point(282, 167);
            this.cmb_articles.Name = "cmb_articles";
            this.cmb_articles.Size = new System.Drawing.Size(493, 24);
            this.cmb_articles.TabIndex = 31;
            // 
            // AddVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(888, 467);
            this.Controls.Add(this.cmb_articles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add_vente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Name = "AddVentes";
            this.Text = "AddVentes";
            this.Load += new System.EventHandler(this.AddVentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add_vente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.NumericUpDown qte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown remise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_articles;
    }
}