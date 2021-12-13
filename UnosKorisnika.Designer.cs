namespace ZadatakZaOcjenuXMLERDGabrielMatosevic20211213
{
    partial class UnosKorisnika
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
            this.KorisnikIme = new System.Windows.Forms.TextBox();
            this.KorisnikPrezime = new System.Windows.Forms.TextBox();
            this.KorisnikOIB = new System.Windows.Forms.TextBox();
            this.KorisnikEmail = new System.Windows.Forms.TextBox();
            this.UnosKorisnikaButun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KorisnikIme
            // 
            this.KorisnikIme.Location = new System.Drawing.Point(315, 79);
            this.KorisnikIme.Name = "KorisnikIme";
            this.KorisnikIme.Size = new System.Drawing.Size(100, 20);
            this.KorisnikIme.TabIndex = 0;
            this.KorisnikIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KorisnikPrezime
            // 
            this.KorisnikPrezime.Location = new System.Drawing.Point(315, 105);
            this.KorisnikPrezime.Name = "KorisnikPrezime";
            this.KorisnikPrezime.Size = new System.Drawing.Size(100, 20);
            this.KorisnikPrezime.TabIndex = 1;
            // 
            // KorisnikOIB
            // 
            this.KorisnikOIB.Location = new System.Drawing.Point(315, 131);
            this.KorisnikOIB.Name = "KorisnikOIB";
            this.KorisnikOIB.Size = new System.Drawing.Size(100, 20);
            this.KorisnikOIB.TabIndex = 2;
            // 
            // KorisnikEmail
            // 
            this.KorisnikEmail.Location = new System.Drawing.Point(315, 157);
            this.KorisnikEmail.Name = "KorisnikEmail";
            this.KorisnikEmail.Size = new System.Drawing.Size(100, 20);
            this.KorisnikEmail.TabIndex = 3;
            // 
            // UnosKorisnikaButun
            // 
            this.UnosKorisnikaButun.Location = new System.Drawing.Point(315, 183);
            this.UnosKorisnikaButun.Name = "UnosKorisnikaButun";
            this.UnosKorisnikaButun.Size = new System.Drawing.Size(100, 23);
            this.UnosKorisnikaButun.TabIndex = 5;
            this.UnosKorisnikaButun.Text = "Unos";
            this.UnosKorisnikaButun.UseVisualStyleBackColor = true;
            this.UnosKorisnikaButun.Click += new System.EventHandler(this.UnosKorisnikaButun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // UnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosKorisnikaButun);
            this.Controls.Add(this.KorisnikEmail);
            this.Controls.Add(this.KorisnikOIB);
            this.Controls.Add(this.KorisnikPrezime);
            this.Controls.Add(this.KorisnikIme);
            this.Name = "UnosKorisnika";
            this.Text = "UnosKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KorisnikIme;
        private System.Windows.Forms.TextBox KorisnikPrezime;
        private System.Windows.Forms.TextBox KorisnikOIB;
        private System.Windows.Forms.TextBox KorisnikEmail;
        private System.Windows.Forms.Button UnosKorisnikaButun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}