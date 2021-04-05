
namespace Servis_Racunara
{
    partial class PromjenaLozinkeForma
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
            this.lbStaraLozinka = new System.Windows.Forms.Label();
            this.lbNovaLozinka = new System.Windows.Forms.Label();
            this.lbPotvrdaLozinke = new System.Windows.Forms.Label();
            this.tbStaraLozinka = new System.Windows.Forms.TextBox();
            this.tbNovaLozinka = new System.Windows.Forms.TextBox();
            this.tbPotvrtaLozinke = new System.Windows.Forms.TextBox();
            this.btPromjeniLozinku = new System.Windows.Forms.Button();
            this.lbGreska = new System.Windows.Forms.Label();
            this.lbImeKorisnika = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStaraLozinka
            // 
            this.lbStaraLozinka.AutoSize = true;
            this.lbStaraLozinka.Location = new System.Drawing.Point(34, 79);
            this.lbStaraLozinka.Name = "lbStaraLozinka";
            this.lbStaraLozinka.Size = new System.Drawing.Size(74, 13);
            this.lbStaraLozinka.TabIndex = 0;
            this.lbStaraLozinka.Text = "Stara lozinka :";
            // 
            // lbNovaLozinka
            // 
            this.lbNovaLozinka.AutoSize = true;
            this.lbNovaLozinka.Location = new System.Drawing.Point(34, 166);
            this.lbNovaLozinka.Name = "lbNovaLozinka";
            this.lbNovaLozinka.Size = new System.Drawing.Size(79, 13);
            this.lbNovaLozinka.TabIndex = 1;
            this.lbNovaLozinka.Text = "Nova Lozinka :";
            // 
            // lbPotvrdaLozinke
            // 
            this.lbPotvrdaLozinke.AutoSize = true;
            this.lbPotvrdaLozinke.Location = new System.Drawing.Point(34, 252);
            this.lbPotvrdaLozinke.Name = "lbPotvrdaLozinke";
            this.lbPotvrdaLozinke.Size = new System.Drawing.Size(88, 13);
            this.lbPotvrdaLozinke.TabIndex = 2;
            this.lbPotvrdaLozinke.Text = "Potvrdite lozinku:";
            // 
            // tbStaraLozinka
            // 
            this.tbStaraLozinka.Location = new System.Drawing.Point(177, 79);
            this.tbStaraLozinka.Name = "tbStaraLozinka";
            this.tbStaraLozinka.Size = new System.Drawing.Size(233, 20);
            this.tbStaraLozinka.TabIndex = 3;
            this.tbStaraLozinka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNovaLozinka
            // 
            this.tbNovaLozinka.Location = new System.Drawing.Point(177, 166);
            this.tbNovaLozinka.Name = "tbNovaLozinka";
            this.tbNovaLozinka.Size = new System.Drawing.Size(233, 20);
            this.tbNovaLozinka.TabIndex = 4;
            this.tbNovaLozinka.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbPotvrtaLozinke
            // 
            this.tbPotvrtaLozinke.Location = new System.Drawing.Point(177, 252);
            this.tbPotvrtaLozinke.Name = "tbPotvrtaLozinke";
            this.tbPotvrtaLozinke.Size = new System.Drawing.Size(233, 20);
            this.tbPotvrtaLozinke.TabIndex = 5;
            this.tbPotvrtaLozinke.TextChanged += new System.EventHandler(this.tbPotvrtaLozinke_TextChanged);
            // 
            // btPromjeniLozinku
            // 
            this.btPromjeniLozinku.Location = new System.Drawing.Point(358, 309);
            this.btPromjeniLozinku.Name = "btPromjeniLozinku";
            this.btPromjeniLozinku.Size = new System.Drawing.Size(122, 38);
            this.btPromjeniLozinku.TabIndex = 6;
            this.btPromjeniLozinku.Text = "SACUVAJ";
            this.btPromjeniLozinku.UseVisualStyleBackColor = true;
            this.btPromjeniLozinku.Click += new System.EventHandler(this.btPromjeniLozinku_Click);
            // 
            // lbGreska
            // 
            this.lbGreska.AutoSize = true;
            this.lbGreska.ForeColor = System.Drawing.Color.Red;
            this.lbGreska.Location = new System.Drawing.Point(34, 322);
            this.lbGreska.Name = "lbGreska";
            this.lbGreska.Size = new System.Drawing.Size(0, 13);
            this.lbGreska.TabIndex = 7;
            // 
            // lbImeKorisnika
            // 
            this.lbImeKorisnika.AutoSize = true;
            this.lbImeKorisnika.Location = new System.Drawing.Point(174, 23);
            this.lbImeKorisnika.Name = "lbImeKorisnika";
            this.lbImeKorisnika.Size = new System.Drawing.Size(50, 13);
            this.lbImeKorisnika.TabIndex = 8;
            this.lbImeKorisnika.Text = "Korisnik :";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(334, 23);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(35, 13);
            this.lbIme.TabIndex = 9;
            this.lbIme.Text = "admin";
            // 
            // PromjenaLozinkeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 377);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.lbImeKorisnika);
            this.Controls.Add(this.lbGreska);
            this.Controls.Add(this.btPromjeniLozinku);
            this.Controls.Add(this.tbPotvrtaLozinke);
            this.Controls.Add(this.tbNovaLozinka);
            this.Controls.Add(this.tbStaraLozinka);
            this.Controls.Add(this.lbPotvrdaLozinke);
            this.Controls.Add(this.lbNovaLozinka);
            this.Controls.Add(this.lbStaraLozinka);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 416);
            this.MinimumSize = new System.Drawing.Size(529, 416);
            this.Name = "PromjenaLozinkeForma";
            this.Text = "PromjenaLozinkeForma";
            this.Load += new System.EventHandler(this.PromjenaLozinkeForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStaraLozinka;
        private System.Windows.Forms.Label lbNovaLozinka;
        private System.Windows.Forms.Label lbPotvrdaLozinke;
        private System.Windows.Forms.TextBox tbStaraLozinka;
        private System.Windows.Forms.TextBox tbNovaLozinka;
        private System.Windows.Forms.TextBox tbPotvrtaLozinke;
        private System.Windows.Forms.Button btPromjeniLozinku;
        private System.Windows.Forms.Label lbGreska;
        private System.Windows.Forms.Label lbImeKorisnika;
        public System.Windows.Forms.Label lbIme;
    }
}