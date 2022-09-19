namespace klasaArraylist
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
            this.btnNovi = new System.Windows.Forms.Button();
            this.txtBoxNovi = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(23, 21);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(166, 23);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi automobil";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // txtBoxNovi
            // 
            this.txtBoxNovi.Location = new System.Drawing.Point(23, 60);
            this.txtBoxNovi.Name = "txtBoxNovi";
            this.txtBoxNovi.Size = new System.Drawing.Size(275, 20);
            this.txtBoxNovi.TabIndex = 1;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(304, 57);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(69, 23);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(23, 99);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(350, 282);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(164, 387);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(87, 51);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtBoxNovi);
            this.Controls.Add(this.btnNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.TextBox txtBoxNovi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btnObrisi;
    }
}

