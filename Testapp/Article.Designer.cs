﻿
namespace Testapp
{
    partial class Article
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete_article = new System.Windows.Forms.Button();
            this.btn_add_article = new System.Windows.Forms.Button();
            this.btn_modifier_article = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_mois = new System.Windows.Forms.ComboBox();
            this.cmb_annee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 547);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1077, 413);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1077, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 134);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_delete_article);
            this.panel5.Controls.Add(this.btn_add_article);
            this.panel5.Controls.Add(this.btn_modifier_article);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1077, 53);
            this.panel5.TabIndex = 4;
            // 
            // btn_delete_article
            // 
            this.btn_delete_article.BackColor = System.Drawing.Color.Red;
            this.btn_delete_article.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_article.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_article.ForeColor = System.Drawing.Color.White;
            this.btn_delete_article.Location = new System.Drawing.Point(621, 0);
            this.btn_delete_article.Name = "btn_delete_article";
            this.btn_delete_article.Size = new System.Drawing.Size(152, 53);
            this.btn_delete_article.TabIndex = 2;
            this.btn_delete_article.Text = "Supprimer";
            this.btn_delete_article.UseVisualStyleBackColor = false;
            this.btn_delete_article.Click += new System.EventHandler(this.btn_delete_article_Click);
            // 
            // btn_add_article
            // 
            this.btn_add_article.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_article.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_article.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_article.ForeColor = System.Drawing.Color.White;
            this.btn_add_article.Location = new System.Drawing.Point(773, 0);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(152, 53);
            this.btn_add_article.TabIndex = 0;
            this.btn_add_article.Text = "Ajouter";
            this.btn_add_article.UseVisualStyleBackColor = false;
            this.btn_add_article.Click += new System.EventHandler(this.btn_add_article_Click);
            // 
            // btn_modifier_article
            // 
            this.btn_modifier_article.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_modifier_article.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifier_article.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_modifier_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier_article.ForeColor = System.Drawing.Color.White;
            this.btn_modifier_article.Location = new System.Drawing.Point(925, 0);
            this.btn_modifier_article.Name = "btn_modifier_article";
            this.btn_modifier_article.Size = new System.Drawing.Size(152, 53);
            this.btn_modifier_article.TabIndex = 1;
            this.btn_modifier_article.Text = "Modifier";
            this.btn_modifier_article.UseVisualStyleBackColor = false;
            this.btn_modifier_article.Click += new System.EventHandler(this.btn_modifier_article_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_annee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_mois);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mois:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(793, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 24);
            this.textBox1.TabIndex = 2;
            // 
            // cmb_mois
            // 
            this.cmb_mois.FormattingEnabled = true;
            this.cmb_mois.Location = new System.Drawing.Point(62, 22);
            this.cmb_mois.Name = "cmb_mois";
            this.cmb_mois.Size = new System.Drawing.Size(121, 26);
            this.cmb_mois.TabIndex = 4;
            // 
            // cmb_annee
            // 
            this.cmb_annee.FormattingEnabled = true;
            this.cmb_annee.Location = new System.Drawing.Point(260, 22);
            this.cmb_annee.Name = "cmb_annee";
            this.cmb_annee.Size = new System.Drawing.Size(121, 26);
            this.cmb_annee.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "année:";
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Article";
            this.Size = new System.Drawing.Size(1077, 547);
            this.Load += new System.EventHandler(this.Article_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_delete_article;
        private System.Windows.Forms.Button btn_add_article;
        private System.Windows.Forms.Button btn_modifier_article;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_mois;
        private System.Windows.Forms.ComboBox cmb_annee;
        private System.Windows.Forms.Label label2;
    }
}
