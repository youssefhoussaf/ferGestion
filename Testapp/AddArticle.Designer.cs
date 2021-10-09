
namespace Testapp
{
    partial class AddArticle
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nub_prix = new System.Windows.Forms.NumericUpDown();
            this.nub_stockI = new System.Windows.Forms.NumericUpDown();
            this.nub_stockS = new System.Windows.Forms.NumericUpDown();
            this.nub_stockA = new System.Windows.Forms.NumericUpDown();
            this.btn_add_article = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nub_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_stockI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_stockS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_stockA)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(251, 49);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(371, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Article nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock Initiale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock Sortie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(91, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock Actuel:";
            // 
            // nub_prix
            // 
            this.nub_prix.Location = new System.Drawing.Point(251, 92);
            this.nub_prix.Name = "nub_prix";
            this.nub_prix.Size = new System.Drawing.Size(371, 20);
            this.nub_prix.TabIndex = 10;
            // 
            // nub_stockI
            // 
            this.nub_stockI.Location = new System.Drawing.Point(251, 141);
            this.nub_stockI.Name = "nub_stockI";
            this.nub_stockI.Size = new System.Drawing.Size(371, 20);
            this.nub_stockI.TabIndex = 11;
            // 
            // nub_stockS
            // 
            this.nub_stockS.Location = new System.Drawing.Point(251, 188);
            this.nub_stockS.Name = "nub_stockS";
            this.nub_stockS.Size = new System.Drawing.Size(371, 20);
            this.nub_stockS.TabIndex = 12;
            // 
            // nub_stockA
            // 
            this.nub_stockA.Location = new System.Drawing.Point(251, 235);
            this.nub_stockA.Name = "nub_stockA";
            this.nub_stockA.Size = new System.Drawing.Size(371, 20);
            this.nub_stockA.TabIndex = 13;
            // 
            // btn_add_article
            // 
            this.btn_add_article.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_article.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_article.ForeColor = System.Drawing.Color.White;
            this.btn_add_article.Location = new System.Drawing.Point(288, 300);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(152, 53);
            this.btn_add_article.TabIndex = 14;
            this.btn_add_article.Text = "Ajouter";
            this.btn_add_article.UseVisualStyleBackColor = false;
            this.btn_add_article.Click += new System.EventHandler(this.btn_add_article_Click);
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(720, 396);
            this.Controls.Add(this.btn_add_article);
            this.Controls.Add(this.nub_stockA);
            this.Controls.Add(this.nub_stockS);
            this.Controls.Add(this.nub_stockI);
            this.Controls.Add(this.nub_prix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddArticle";
            this.Text = "Ajouter Article";
            ((System.ComponentModel.ISupportInitialize)(this.nub_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_stockI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_stockS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_stockA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nub_prix;
        private System.Windows.Forms.NumericUpDown nub_stockI;
        private System.Windows.Forms.NumericUpDown nub_stockS;
        private System.Windows.Forms.NumericUpDown nub_stockA;
        private System.Windows.Forms.Button btn_add_article;
    }
}