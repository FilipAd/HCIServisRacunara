
namespace Servis_Racunara
{
    partial class PrijavaForma
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
            this.btPrijava = new System.Windows.Forms.Button();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.gbJezici = new System.Windows.Forms.GroupBox();
            this.rbPrevediNaSrpski = new System.Windows.Forms.RadioButton();
            this.rbPrevediNaengleski = new System.Windows.Forms.RadioButton();
            this.cbKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.lbGreska = new System.Windows.Forms.Label();
            this.gbJezici.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPrijava
            // 
            this.btPrijava.Location = new System.Drawing.Point(348, 230);
            this.btPrijava.Name = "btPrijava";
            this.btPrijava.Size = new System.Drawing.Size(99, 36);
            this.btPrijava.TabIndex = 0;
            this.btPrijava.Text = "PRIJAVA";
            this.btPrijava.UseVisualStyleBackColor = true;
            this.btPrijava.Click += new System.EventHandler(this.btPrijava_Click);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(200, 159);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(247, 20);
            this.tbLozinka.TabIndex = 2;
            this.tbLozinka.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(74, 89);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(101, 13);
            this.lbKorisnickoIme.TabIndex = 3;
            this.lbKorisnickoIme.Text = "KORISNICKO IME :";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Location = new System.Drawing.Point(74, 166);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(59, 13);
            this.lbLozinka.TabIndex = 4;
            this.lbLozinka.Text = "LOZINKA :";
            // 
            // gbJezici
            // 
            this.gbJezici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbJezici.Controls.Add(this.rbPrevediNaSrpski);
            this.gbJezici.Controls.Add(this.rbPrevediNaengleski);
            this.gbJezici.Location = new System.Drawing.Point(493, 12);
            this.gbJezici.Name = "gbJezici";
            this.gbJezici.Size = new System.Drawing.Size(83, 115);
            this.gbJezici.TabIndex = 52;
            this.gbJezici.TabStop = false;
            // 
            // rbPrevediNaSrpski
            // 
            this.rbPrevediNaSrpski.AutoSize = true;
            this.rbPrevediNaSrpski.Image = global::Servis_Racunara.Properties.Resources.hiclipart_com__3_;
            this.rbPrevediNaSrpski.Location = new System.Drawing.Point(10, 13);
            this.rbPrevediNaSrpski.Name = "rbPrevediNaSrpski";
            this.rbPrevediNaSrpski.Size = new System.Drawing.Size(59, 45);
            this.rbPrevediNaSrpski.TabIndex = 49;
            this.rbPrevediNaSrpski.TabStop = true;
            this.rbPrevediNaSrpski.UseVisualStyleBackColor = true;
            this.rbPrevediNaSrpski.CheckedChanged += new System.EventHandler(this.rbPrevediNaSrpski_CheckedChanged);
            // 
            // rbPrevediNaengleski
            // 
            this.rbPrevediNaengleski.AutoSize = true;
            this.rbPrevediNaengleski.Image = global::Servis_Racunara.Properties.Resources.hiclipart_com__4_;
            this.rbPrevediNaengleski.Location = new System.Drawing.Point(10, 64);
            this.rbPrevediNaengleski.Name = "rbPrevediNaengleski";
            this.rbPrevediNaengleski.Size = new System.Drawing.Size(59, 45);
            this.rbPrevediNaengleski.TabIndex = 50;
            this.rbPrevediNaengleski.TabStop = true;
            this.rbPrevediNaengleski.UseVisualStyleBackColor = true;
            this.rbPrevediNaengleski.CheckedChanged += new System.EventHandler(this.rbPrevediNaengleski_CheckedChanged);
            // 
            // cbKorisnickoIme
            // 
            this.cbKorisnickoIme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbKorisnickoIme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKorisnickoIme.FormattingEnabled = true;
            this.cbKorisnickoIme.Location = new System.Drawing.Point(200, 86);
            this.cbKorisnickoIme.Name = "cbKorisnickoIme";
            this.cbKorisnickoIme.Size = new System.Drawing.Size(247, 21);
            this.cbKorisnickoIme.TabIndex = 53;
            this.cbKorisnickoIme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbGreska
            // 
            this.lbGreska.AutoSize = true;
            this.lbGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreska.ForeColor = System.Drawing.Color.Red;
            this.lbGreska.Location = new System.Drawing.Point(41, 230);
            this.lbGreska.Name = "lbGreska";
            this.lbGreska.Size = new System.Drawing.Size(275, 20);
            this.lbGreska.TabIndex = 54;
            this.lbGreska.Text = "POGRESNA LOZINKA ILI KORISNIK";
            this.lbGreska.Visible = false;
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servis_Racunara.Properties.Resources.wp2747048;
            this.ClientSize = new System.Drawing.Size(588, 348);
            this.Controls.Add(this.lbGreska);
            this.Controls.Add(this.cbKorisnickoIme);
            this.Controls.Add(this.gbJezici);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.lbKorisnickoIme);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.btPrijava);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 387);
            this.Name = "PrijavaForma";
            this.Text = "Prijava";
            this.gbJezici.ResumeLayout(false);
            this.gbJezici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPrijava;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.GroupBox gbJezici;
        public System.Windows.Forms.RadioButton rbPrevediNaSrpski;
        public System.Windows.Forms.RadioButton rbPrevediNaengleski;
        public System.Windows.Forms.ComboBox cbKorisnickoIme;
        private System.Windows.Forms.Label lbGreska;
    }
}