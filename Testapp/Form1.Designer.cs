
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.btn_articles = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btn_articles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 771);
            this.panel1.TabIndex = 0;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(284, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1027, 771);
            this.container.TabIndex = 1;
            // 
            // btn_articles
            // 
            this.btn_articles.Location = new System.Drawing.Point(84, 108);
            this.btn_articles.Name = "btn_articles";
            this.btn_articles.Size = new System.Drawing.Size(75, 23);
            this.btn_articles.TabIndex = 0;
            this.btn_articles.Text = "Articles";
            this.btn_articles.UseVisualStyleBackColor = true;
            this.btn_articles.Click += new System.EventHandler(this.btn_articles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 771);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_articles;
        private System.Windows.Forms.Panel container;
    }
}

