
namespace Testapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_articles = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.btn_ventes = new System.Windows.Forms.Button();
            this.btn_achats = new System.Windows.Forms.Button();
            this.btn_types = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_types);
            this.panel1.Controls.Add(this.btn_achats);
            this.panel1.Controls.Add(this.btn_ventes);
            this.panel1.Controls.Add(this.btn_articles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 771);
            this.panel1.TabIndex = 0;
            // 
            // btn_articles
            // 
            this.btn_articles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_articles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_articles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_articles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_articles.ForeColor = System.Drawing.Color.White;
            this.btn_articles.Location = new System.Drawing.Point(0, 119);
            this.btn_articles.Name = "btn_articles";
            this.btn_articles.Size = new System.Drawing.Size(284, 64);
            this.btn_articles.TabIndex = 0;
            this.btn_articles.Text = "Articles";
            this.btn_articles.UseVisualStyleBackColor = false;
            this.btn_articles.Click += new System.EventHandler(this.btn_articles_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(284, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1027, 771);
            this.container.TabIndex = 1;
            // 
            // btn_ventes
            // 
            this.btn_ventes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_ventes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventes.ForeColor = System.Drawing.Color.White;
            this.btn_ventes.Location = new System.Drawing.Point(0, 182);
            this.btn_ventes.Name = "btn_ventes";
            this.btn_ventes.Size = new System.Drawing.Size(284, 64);
            this.btn_ventes.TabIndex = 1;
            this.btn_ventes.Text = "Ventes";
            this.btn_ventes.UseVisualStyleBackColor = false;
            // 
            // btn_achats
            // 
            this.btn_achats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_achats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_achats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_achats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_achats.ForeColor = System.Drawing.Color.White;
            this.btn_achats.Location = new System.Drawing.Point(0, 245);
            this.btn_achats.Name = "btn_achats";
            this.btn_achats.Size = new System.Drawing.Size(284, 64);
            this.btn_achats.TabIndex = 2;
            this.btn_achats.Text = "Achats";
            this.btn_achats.UseVisualStyleBackColor = false;
            // 
            // btn_types
            // 
            this.btn_types.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_types.ForeColor = System.Drawing.Color.White;
            this.btn_types.Location = new System.Drawing.Point(0, 307);
            this.btn_types.Name = "btn_types";
            this.btn_types.Size = new System.Drawing.Size(284, 64);
            this.btn_types.TabIndex = 3;
            this.btn_types.Text = "Types d\'article";
            this.btn_types.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "PF Aluminium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 771);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_articles;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_types;
        private System.Windows.Forms.Button btn_achats;
        private System.Windows.Forms.Button btn_ventes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

