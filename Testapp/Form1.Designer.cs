
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_types = new System.Windows.Forms.Button();
            this.btn_achats = new System.Windows.Forms.Button();
            this.btn_ventes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_maxi = new System.Windows.Forms.Button();
            this.btn_mini = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_articles = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.headerBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_types);
            this.panel1.Controls.Add(this.btn_achats);
            this.panel1.Controls.Add(this.btn_ventes);
            this.panel1.Controls.Add(this.btn_articles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 1050);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(53, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "PF Aluminium";
            // 
            // btn_types
            // 
            this.btn_types.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_types.FlatAppearance.BorderSize = 0;
            this.btn_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_types.ForeColor = System.Drawing.Color.White;
            this.btn_types.Image = global::Testapp.Properties.Resources.i_beam_removebg_preview__3_;
            this.btn_types.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_types.Location = new System.Drawing.Point(0, 472);
            this.btn_types.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_types.Name = "btn_types";
            this.btn_types.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_types.Size = new System.Drawing.Size(343, 98);
            this.btn_types.TabIndex = 3;
            this.btn_types.Text = " Types d\'article";
            this.btn_types.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_types.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_types.UseVisualStyleBackColor = false;
            this.btn_types.Click += new System.EventHandler(this.btn_types_Click);
            // 
            // btn_achats
            // 
            this.btn_achats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_achats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_achats.FlatAppearance.BorderSize = 0;
            this.btn_achats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_achats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_achats.ForeColor = System.Drawing.Color.White;
            this.btn_achats.Image = global::Testapp.Properties.Resources.i_beam_removebg_preview__3_;
            this.btn_achats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_achats.Location = new System.Drawing.Point(0, 377);
            this.btn_achats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_achats.Name = "btn_achats";
            this.btn_achats.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_achats.Size = new System.Drawing.Size(343, 98);
            this.btn_achats.TabIndex = 2;
            this.btn_achats.Text = " Achats";
            this.btn_achats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_achats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_achats.UseVisualStyleBackColor = false;
            // 
            // btn_ventes
            // 
            this.btn_ventes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_ventes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventes.FlatAppearance.BorderSize = 0;
            this.btn_ventes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventes.ForeColor = System.Drawing.Color.White;
            this.btn_ventes.Image = global::Testapp.Properties.Resources.i_beam_removebg_preview__3_;
            this.btn_ventes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventes.Location = new System.Drawing.Point(0, 280);
            this.btn_ventes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ventes.Name = "btn_ventes";
            this.btn_ventes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_ventes.Size = new System.Drawing.Size(343, 98);
            this.btn_ventes.TabIndex = 1;
            this.btn_ventes.Text = " Ventes";
            this.btn_ventes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ventes.UseVisualStyleBackColor = false;
            this.btn_ventes.Click += new System.EventHandler(this.btn_ventes_Click);
            this.btn_ventes.MouseEnter += new System.EventHandler(this.btn_ventes_MouseEnter);
            this.btn_ventes.MouseLeave += new System.EventHandler(this.btn_ventes_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.container);
            this.panel2.Controls.Add(this.headerBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1577, 1050);
            this.panel2.TabIndex = 2;
            // 
            // headerBar
            // 
            this.headerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.headerBar.Controls.Add(this.panel3);
            this.headerBar.Controls.Add(this.lbl_title);
            this.headerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBar.Location = new System.Drawing.Point(0, 0);
            this.headerBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new System.Drawing.Size(1577, 138);
            this.headerBar.TabIndex = 2;
            this.headerBar.Paint += new System.Windows.Forms.PaintEventHandler(this.headerBar_Paint);
            this.headerBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerBar_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_maxi);
            this.panel3.Controls.Add(this.btn_mini);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1424, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 138);
            this.panel3.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(42, 32);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 33);
            this.lbl_title.TabIndex = 0;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 138);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1577, 912);
            this.container.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Testapp.Properties.Resources.istockphoto_1131230925_170667a_removebg_preview;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(106, 9);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 31);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_maxi
            // 
            this.btn_maxi.BackgroundImage = global::Testapp.Properties.Resources.window_maximize_5;
            this.btn_maxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maxi.FlatAppearance.BorderSize = 0;
            this.btn_maxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maxi.Location = new System.Drawing.Point(57, 9);
            this.btn_maxi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_maxi.Name = "btn_maxi";
            this.btn_maxi.Size = new System.Drawing.Size(30, 31);
            this.btn_maxi.TabIndex = 1;
            this.btn_maxi.UseVisualStyleBackColor = true;
            this.btn_maxi.Click += new System.EventHandler(this.btn_maxi_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.BackgroundImage = global::Testapp.Properties.Resources.téléchargement_removebg_preview;
            this.btn_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Location = new System.Drawing.Point(6, 9);
            this.btn_mini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(30, 31);
            this.btn_mini.TabIndex = 0;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_articles
            // 
            this.btn_articles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_articles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_articles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_articles.FlatAppearance.BorderSize = 0;
            this.btn_articles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_articles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_articles.ForeColor = System.Drawing.Color.White;
            this.btn_articles.Image = global::Testapp.Properties.Resources.i_beam_removebg_preview__3_;
            this.btn_articles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_articles.Location = new System.Drawing.Point(0, 183);
            this.btn_articles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_articles.Name = "btn_articles";
            this.btn_articles.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_articles.Size = new System.Drawing.Size(343, 98);
            this.btn_articles.TabIndex = 0;
            this.btn_articles.Text = " Articles";
            this.btn_articles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_articles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_articles.UseVisualStyleBackColor = false;
            this.btn_articles.Click += new System.EventHandler(this.btn_articles_Click);
            this.btn_articles.MouseEnter += new System.EventHandler(this.btn_articles_MouseEnter);
            this.btn_articles.MouseLeave += new System.EventHandler(this.btn_articles_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1300, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.headerBar.ResumeLayout(false);
            this.headerBar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_articles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_types;
        private System.Windows.Forms.Button btn_achats;
        private System.Windows.Forms.Button btn_ventes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel headerBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_maxi;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel container;
    }
}

