namespace ZadatakZaOcjenuXMLERDGabrielMatosevic20211213
{
    partial class UnosKnjige
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnosKnjigeButun = new System.Windows.Forms.Button();
            this.KnjigaAutor = new System.Windows.Forms.TextBox();
            this.KnjigaOpis = new System.Windows.Forms.TextBox();
            this.KnjigaIme = new System.Windows.Forms.TextBox();
            this.KnjigaIzdanje = new System.Windows.Forms.TextBox();
            this.KnjigaStanje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Izdanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Opis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ime";
            // 
            // UnosKnjigeButun
            // 
            this.UnosKnjigeButun.Location = new System.Drawing.Point(335, 254);
            this.UnosKnjigeButun.Name = "UnosKnjigeButun";
            this.UnosKnjigeButun.Size = new System.Drawing.Size(100, 23);
            this.UnosKnjigeButun.TabIndex = 14;
            this.UnosKnjigeButun.Text = "Unos";
            this.UnosKnjigeButun.UseVisualStyleBackColor = true;
            this.UnosKnjigeButun.Click += new System.EventHandler(this.UnosKnjigeButun_Click);
            // 
            // KnjigaAutor
            // 
            this.KnjigaAutor.Location = new System.Drawing.Point(335, 175);
            this.KnjigaAutor.Name = "KnjigaAutor";
            this.KnjigaAutor.Size = new System.Drawing.Size(100, 20);
            this.KnjigaAutor.TabIndex = 12;
            // 
            // KnjigaOpis
            // 
            this.KnjigaOpis.Location = new System.Drawing.Point(335, 149);
            this.KnjigaOpis.Name = "KnjigaOpis";
            this.KnjigaOpis.Size = new System.Drawing.Size(100, 20);
            this.KnjigaOpis.TabIndex = 11;
            // 
            // KnjigaIme
            // 
            this.KnjigaIme.Location = new System.Drawing.Point(335, 123);
            this.KnjigaIme.Name = "KnjigaIme";
            this.KnjigaIme.Size = new System.Drawing.Size(100, 20);
            this.KnjigaIme.TabIndex = 10;
            // 
            // KnjigaIzdanje
            // 
            this.KnjigaIzdanje.Location = new System.Drawing.Point(335, 201);
            this.KnjigaIzdanje.Name = "KnjigaIzdanje";
            this.KnjigaIzdanje.Size = new System.Drawing.Size(100, 20);
            this.KnjigaIzdanje.TabIndex = 19;
            // 
            // KnjigaStanje
            // 
            this.KnjigaStanje.Location = new System.Drawing.Point(335, 227);
            this.KnjigaStanje.Name = "KnjigaStanje";
            this.KnjigaStanje.Size = new System.Drawing.Size(100, 20);
            this.KnjigaStanje.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stanje";
            // 
            // UnosKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KnjigaStanje);
            this.Controls.Add(this.KnjigaIzdanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosKnjigeButun);
            this.Controls.Add(this.KnjigaAutor);
            this.Controls.Add(this.KnjigaOpis);
            this.Controls.Add(this.KnjigaIme);
            this.Name = "UnosKnjige";
            this.Text = "UnosKnjige";
            this.Load += new System.EventHandler(this.UnosKnjige_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UnosKnjigeButun;
        private System.Windows.Forms.TextBox KnjigaAutor;
        private System.Windows.Forms.TextBox KnjigaOpis;
        private System.Windows.Forms.TextBox KnjigaIme;
        private System.Windows.Forms.TextBox KnjigaIzdanje;
        private System.Windows.Forms.TextBox KnjigaStanje;
        private System.Windows.Forms.Label label5;
    }
}