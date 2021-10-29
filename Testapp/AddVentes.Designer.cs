
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_articles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remise)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_vente
            // 
            this.btn_add_vente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btn_add_vente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_vente.FlatAppearance.BorderSize = 3;
            this.btn_add_vente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_vente.ForeColor = System.Drawing.Color.White;
            this.btn_add_vente.Location = new System.Drawing.Point(280, 272);
            this.btn_add_vente.Name = "btn_add_vente";
            this.btn_add_vente.Size = new System.Drawing.Size(120, 44);
            this.btn_add_vente.TabIndex = 21;
            this.btn_add_vente.Text = "AJOUTER";
            this.btn_add_vente.UseVisualStyleBackColor = false;
            this.btn_add_vente.Click += new System.EventHandler(this.btn_add_vente_Click);
            this.btn_add_vente.MouseEnter += new System.EventHandler(this.btn_add_vente_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom de  client :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(211, 111);
            this.txt_nom.MaxLength = 49;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(371, 20);
            this.txt_nom.TabIndex = 16;
            // 
            // qte
            // 
            this.qte.DecimalPlaces = 2;
            this.qte.Location = new System.Drawing.Point(211, 178);
            this.qte.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.qte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(371, 20);
            this.qte.TabIndex = 24;
            this.qte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qte.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Qté :";
            // 
            // remise
            // 
            this.remise.DecimalPlaces = 2;
            this.remise.Location = new System.Drawing.Point(211, 213);
            this.remise.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.remise.Name = "remise";
            this.remise.Size = new System.Drawing.Size(371, 20);
            this.remise.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Remise : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Article :";
            // 
            // cmb_articles
            // 
            this.cmb_articles.FormattingEnabled = true;
            this.cmb_articles.Location = new System.Drawing.Point(211, 144);
            this.cmb_articles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_articles.Name = "cmb_articles";
            this.cmb_articles.Size = new System.Drawing.Size(371, 21);
            this.cmb_articles.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(666, 50);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nouveau vente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(666, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_articles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add_vente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddVentes";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_articles;
        private System.Windows.Forms.Label label3;
    }
}