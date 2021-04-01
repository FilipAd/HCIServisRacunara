
namespace Servis_Racunara
{
    partial class KomponentaStavkaForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbKomponentaStavka = new System.Windows.Forms.GroupBox();
            this.dgvKomponentaStavka = new System.Windows.Forms.DataGridView();
            this.ColumnSifraKomponenteKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazivKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCijenaPoKomaduKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDostupnaKolicinaKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOznaci = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbBrojRadnogNalogaKS = new System.Windows.Forms.Label();
            this.lbSifraKomponenteKS = new System.Windows.Forms.Label();
            this.lbDostupnaKolicinaKS = new System.Windows.Forms.Label();
            this.tbBrojNalogaKS = new System.Windows.Forms.TextBox();
            this.tbSifraKomponenteKS = new System.Windows.Forms.TextBox();
            this.tbDostupnoKS = new System.Windows.Forms.TextBox();
            this.lbKolicinaKS = new System.Windows.Forms.Label();
            this.lbRabatKS = new System.Windows.Forms.Label();
            this.lbUkupnaCijena = new System.Windows.Forms.Label();
            this.tbKolicinaKS = new System.Windows.Forms.TextBox();
            this.tbRabatKS = new System.Windows.Forms.TextBox();
            this.tbUkupnaCijenaKS = new System.Windows.Forms.TextBox();
            this.btObracunajKS = new System.Windows.Forms.Button();
            this.btDodajNaNalog = new System.Windows.Forms.Button();
            this.lbFilterKS = new System.Windows.Forms.Label();
            this.tbFilterKS = new System.Windows.Forms.TextBox();
            this.lbJedinicnaCijena = new System.Windows.Forms.Label();
            this.tbJedinicnaCijenaKS = new System.Windows.Forms.TextBox();
            this.lbNazivKS = new System.Windows.Forms.Label();
            this.tbNazivKS = new System.Windows.Forms.TextBox();
            this.gbKomponentaStavka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponentaStavka)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKomponentaStavka
            // 
            this.gbKomponentaStavka.Controls.Add(this.dgvKomponentaStavka);
            this.gbKomponentaStavka.Location = new System.Drawing.Point(34, 68);
            this.gbKomponentaStavka.Name = "gbKomponentaStavka";
            this.gbKomponentaStavka.Size = new System.Drawing.Size(888, 286);
            this.gbKomponentaStavka.TabIndex = 0;
            this.gbKomponentaStavka.TabStop = false;
            this.gbKomponentaStavka.Text = "KOMPONENTE";
            // 
            // dgvKomponentaStavka
            // 
            this.dgvKomponentaStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponentaStavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSifraKomponenteKS,
            this.ColumnNazivKS,
            this.ColumnCijenaPoKomaduKS,
            this.ColumnDostupnaKolicinaKS,
            this.ColumnOznaci});
            this.dgvKomponentaStavka.Location = new System.Drawing.Point(6, 19);
            this.dgvKomponentaStavka.Name = "dgvKomponentaStavka";
            this.dgvKomponentaStavka.Size = new System.Drawing.Size(876, 247);
            this.dgvKomponentaStavka.TabIndex = 0;
            this.dgvKomponentaStavka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomponentaStavka_CellContentClick);
            // 
            // ColumnSifraKomponenteKS
            // 
            this.ColumnSifraKomponenteKS.HeaderText = "Sifra";
            this.ColumnSifraKomponenteKS.Name = "ColumnSifraKomponenteKS";
            // 
            // ColumnNazivKS
            // 
            this.ColumnNazivKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNazivKS.HeaderText = "Naziv";
            this.ColumnNazivKS.Name = "ColumnNazivKS";
            // 
            // ColumnCijenaPoKomaduKS
            // 
            this.ColumnCijenaPoKomaduKS.HeaderText = "Cijena po komadu";
            this.ColumnCijenaPoKomaduKS.Name = "ColumnCijenaPoKomaduKS";
            // 
            // ColumnDostupnaKolicinaKS
            // 
            this.ColumnDostupnaKolicinaKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnDostupnaKolicinaKS.HeaderText = "DostupnaKolicina";
            this.ColumnDostupnaKolicinaKS.Name = "ColumnDostupnaKolicinaKS";
            this.ColumnDostupnaKolicinaKS.Width = 115;
            // 
            // ColumnOznaci
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnOznaci.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnOznaci.HeaderText = "Oznaci";
            this.ColumnOznaci.Name = "ColumnOznaci";
            this.ColumnOznaci.Text = "Oznaci";
            this.ColumnOznaci.UseColumnTextForButtonValue = true;
            // 
            // lbBrojRadnogNalogaKS
            // 
            this.lbBrojRadnogNalogaKS.AutoSize = true;
            this.lbBrojRadnogNalogaKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojRadnogNalogaKS.Location = new System.Drawing.Point(30, 373);
            this.lbBrojRadnogNalogaKS.Name = "lbBrojRadnogNalogaKS";
            this.lbBrojRadnogNalogaKS.Size = new System.Drawing.Size(133, 21);
            this.lbBrojRadnogNalogaKS.TabIndex = 1;
            this.lbBrojRadnogNalogaKS.Text = "BROJ NALOGA:";
            // 
            // lbSifraKomponenteKS
            // 
            this.lbSifraKomponenteKS.AutoSize = true;
            this.lbSifraKomponenteKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSifraKomponenteKS.Location = new System.Drawing.Point(30, 408);
            this.lbSifraKomponenteKS.Name = "lbSifraKomponenteKS";
            this.lbSifraKomponenteKS.Size = new System.Drawing.Size(188, 21);
            this.lbSifraKomponenteKS.TabIndex = 2;
            this.lbSifraKomponenteKS.Text = "SIFRA KOMPONENTE:";
            // 
            // lbDostupnaKolicinaKS
            // 
            this.lbDostupnaKolicinaKS.AutoSize = true;
            this.lbDostupnaKolicinaKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDostupnaKolicinaKS.Location = new System.Drawing.Point(30, 476);
            this.lbDostupnaKolicinaKS.Name = "lbDostupnaKolicinaKS";
            this.lbDostupnaKolicinaKS.Size = new System.Drawing.Size(109, 21);
            this.lbDostupnaKolicinaKS.TabIndex = 3;
            this.lbDostupnaKolicinaKS.Text = "DOSTUPNO:";
            // 
            // tbBrojNalogaKS
            // 
            this.tbBrojNalogaKS.Location = new System.Drawing.Point(269, 374);
            this.tbBrojNalogaKS.Name = "tbBrojNalogaKS";
            this.tbBrojNalogaKS.ReadOnly = true;
            this.tbBrojNalogaKS.Size = new System.Drawing.Size(143, 20);
            this.tbBrojNalogaKS.TabIndex = 4;
            // 
            // tbSifraKomponenteKS
            // 
            this.tbSifraKomponenteKS.Location = new System.Drawing.Point(269, 410);
            this.tbSifraKomponenteKS.Name = "tbSifraKomponenteKS";
            this.tbSifraKomponenteKS.ReadOnly = true;
            this.tbSifraKomponenteKS.Size = new System.Drawing.Size(143, 20);
            this.tbSifraKomponenteKS.TabIndex = 5;
            // 
            // tbDostupnoKS
            // 
            this.tbDostupnoKS.Location = new System.Drawing.Point(269, 478);
            this.tbDostupnoKS.Name = "tbDostupnoKS";
            this.tbDostupnoKS.ReadOnly = true;
            this.tbDostupnoKS.Size = new System.Drawing.Size(143, 20);
            this.tbDostupnoKS.TabIndex = 6;
            // 
            // lbKolicinaKS
            // 
            this.lbKolicinaKS.AutoSize = true;
            this.lbKolicinaKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKolicinaKS.Location = new System.Drawing.Point(446, 408);
            this.lbKolicinaKS.Name = "lbKolicinaKS";
            this.lbKolicinaKS.Size = new System.Drawing.Size(98, 21);
            this.lbKolicinaKS.TabIndex = 7;
            this.lbKolicinaKS.Text = "KOLICINA:";
            // 
            // lbRabatKS
            // 
            this.lbRabatKS.AutoSize = true;
            this.lbRabatKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRabatKS.Location = new System.Drawing.Point(446, 451);
            this.lbRabatKS.Name = "lbRabatKS";
            this.lbRabatKS.Size = new System.Drawing.Size(72, 21);
            this.lbRabatKS.TabIndex = 8;
            this.lbRabatKS.Text = "RABAT:";
            // 
            // lbUkupnaCijena
            // 
            this.lbUkupnaCijena.AutoSize = true;
            this.lbUkupnaCijena.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUkupnaCijena.Location = new System.Drawing.Point(446, 494);
            this.lbUkupnaCijena.Name = "lbUkupnaCijena";
            this.lbUkupnaCijena.Size = new System.Drawing.Size(148, 21);
            this.lbUkupnaCijena.TabIndex = 9;
            this.lbUkupnaCijena.Text = "UKUPNA CIJENA:";
            // 
            // tbKolicinaKS
            // 
            this.tbKolicinaKS.Location = new System.Drawing.Point(593, 410);
            this.tbKolicinaKS.Name = "tbKolicinaKS";
            this.tbKolicinaKS.Size = new System.Drawing.Size(190, 20);
            this.tbKolicinaKS.TabIndex = 10;
            this.tbKolicinaKS.TextChanged += new System.EventHandler(this.tbKolicinaKS_TextChanged);
            // 
            // tbRabatKS
            // 
            this.tbRabatKS.Location = new System.Drawing.Point(593, 452);
            this.tbRabatKS.Name = "tbRabatKS";
            this.tbRabatKS.Size = new System.Drawing.Size(190, 20);
            this.tbRabatKS.TabIndex = 11;
            this.tbRabatKS.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbUkupnaCijenaKS
            // 
            this.tbUkupnaCijenaKS.Location = new System.Drawing.Point(644, 496);
            this.tbUkupnaCijenaKS.Name = "tbUkupnaCijenaKS";
            this.tbUkupnaCijenaKS.ReadOnly = true;
            this.tbUkupnaCijenaKS.Size = new System.Drawing.Size(139, 20);
            this.tbUkupnaCijenaKS.TabIndex = 12;
            // 
            // btObracunajKS
            // 
            this.btObracunajKS.BackColor = System.Drawing.Color.Coral;
            this.btObracunajKS.Location = new System.Drawing.Point(814, 408);
            this.btObracunajKS.Name = "btObracunajKS";
            this.btObracunajKS.Size = new System.Drawing.Size(107, 40);
            this.btObracunajKS.TabIndex = 13;
            this.btObracunajKS.Text = "OBRACUNAJ";
            this.btObracunajKS.UseVisualStyleBackColor = false;
            this.btObracunajKS.Click += new System.EventHandler(this.btObracunajKS_Click);
            // 
            // btDodajNaNalog
            // 
            this.btDodajNaNalog.BackColor = System.Drawing.Color.Turquoise;
            this.btDodajNaNalog.Enabled = false;
            this.btDodajNaNalog.Location = new System.Drawing.Point(814, 475);
            this.btDodajNaNalog.Name = "btDodajNaNalog";
            this.btDodajNaNalog.Size = new System.Drawing.Size(107, 40);
            this.btDodajNaNalog.TabIndex = 14;
            this.btDodajNaNalog.Text = "DODAJ NA NALOG";
            this.btDodajNaNalog.UseVisualStyleBackColor = false;
            this.btDodajNaNalog.Click += new System.EventHandler(this.btDodajNaNalog_Click);
            // 
            // lbFilterKS
            // 
            this.lbFilterKS.AutoSize = true;
            this.lbFilterKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterKS.Location = new System.Drawing.Point(517, 41);
            this.lbFilterKS.Name = "lbFilterKS";
            this.lbFilterKS.Size = new System.Drawing.Size(70, 21);
            this.lbFilterKS.TabIndex = 15;
            this.lbFilterKS.Text = "Pretrazi:";
            // 
            // tbFilterKS
            // 
            this.tbFilterKS.Location = new System.Drawing.Point(678, 42);
            this.tbFilterKS.Name = "tbFilterKS";
            this.tbFilterKS.Size = new System.Drawing.Size(244, 20);
            this.tbFilterKS.TabIndex = 16;
            this.tbFilterKS.TextChanged += new System.EventHandler(this.tbFilterKS_TextChanged);
            // 
            // lbJedinicnaCijena
            // 
            this.lbJedinicnaCijena.AutoSize = true;
            this.lbJedinicnaCijena.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJedinicnaCijena.Location = new System.Drawing.Point(30, 514);
            this.lbJedinicnaCijena.Name = "lbJedinicnaCijena";
            this.lbJedinicnaCijena.Size = new System.Drawing.Size(168, 21);
            this.lbJedinicnaCijena.TabIndex = 17;
            this.lbJedinicnaCijena.Text = "JEDINICNA CIJENA:";
            // 
            // tbJedinicnaCijenaKS
            // 
            this.tbJedinicnaCijenaKS.Location = new System.Drawing.Point(269, 516);
            this.tbJedinicnaCijenaKS.Name = "tbJedinicnaCijenaKS";
            this.tbJedinicnaCijenaKS.ReadOnly = true;
            this.tbJedinicnaCijenaKS.Size = new System.Drawing.Size(143, 20);
            this.tbJedinicnaCijenaKS.TabIndex = 18;
            // 
            // lbNazivKS
            // 
            this.lbNazivKS.AutoSize = true;
            this.lbNazivKS.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNazivKS.Location = new System.Drawing.Point(30, 440);
            this.lbNazivKS.Name = "lbNazivKS";
            this.lbNazivKS.Size = new System.Drawing.Size(68, 21);
            this.lbNazivKS.TabIndex = 19;
            this.lbNazivKS.Text = "NAZIV:";
            // 
            // tbNazivKS
            // 
            this.tbNazivKS.Location = new System.Drawing.Point(156, 442);
            this.tbNazivKS.Name = "tbNazivKS";
            this.tbNazivKS.ReadOnly = true;
            this.tbNazivKS.Size = new System.Drawing.Size(256, 20);
            this.tbNazivKS.TabIndex = 20;
            // 
            // KomponentaStavkaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 556);
            this.Controls.Add(this.tbNazivKS);
            this.Controls.Add(this.lbNazivKS);
            this.Controls.Add(this.tbJedinicnaCijenaKS);
            this.Controls.Add(this.lbJedinicnaCijena);
            this.Controls.Add(this.tbFilterKS);
            this.Controls.Add(this.lbFilterKS);
            this.Controls.Add(this.btDodajNaNalog);
            this.Controls.Add(this.btObracunajKS);
            this.Controls.Add(this.tbUkupnaCijenaKS);
            this.Controls.Add(this.tbRabatKS);
            this.Controls.Add(this.tbKolicinaKS);
            this.Controls.Add(this.lbUkupnaCijena);
            this.Controls.Add(this.lbRabatKS);
            this.Controls.Add(this.lbKolicinaKS);
            this.Controls.Add(this.tbDostupnoKS);
            this.Controls.Add(this.tbSifraKomponenteKS);
            this.Controls.Add(this.tbBrojNalogaKS);
            this.Controls.Add(this.lbDostupnaKolicinaKS);
            this.Controls.Add(this.lbSifraKomponenteKS);
            this.Controls.Add(this.lbBrojRadnogNalogaKS);
            this.Controls.Add(this.gbKomponentaStavka);
            this.Name = "KomponentaStavkaForma";
            this.Text = "KomponentaStavka";
            this.Load += new System.EventHandler(this.KomponentaStavka_Load);
            this.gbKomponentaStavka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponentaStavka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKomponentaStavka;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvKomponentaStavka;
        private System.Windows.Forms.Label lbBrojRadnogNalogaKS;
        private System.Windows.Forms.Label lbSifraKomponenteKS;
        private System.Windows.Forms.Label lbDostupnaKolicinaKS;
        private System.Windows.Forms.TextBox tbBrojNalogaKS;
        private System.Windows.Forms.TextBox tbSifraKomponenteKS;
        private System.Windows.Forms.TextBox tbDostupnoKS;
        private System.Windows.Forms.Label lbKolicinaKS;
        private System.Windows.Forms.Label lbRabatKS;
        private System.Windows.Forms.Label lbUkupnaCijena;
        private System.Windows.Forms.TextBox tbKolicinaKS;
        private System.Windows.Forms.TextBox tbRabatKS;
        private System.Windows.Forms.TextBox tbUkupnaCijenaKS;
        private System.Windows.Forms.Button btObracunajKS;
        private System.Windows.Forms.Button btDodajNaNalog;
        private System.Windows.Forms.Label lbFilterKS;
        private System.Windows.Forms.TextBox tbFilterKS;
        private System.Windows.Forms.Label lbJedinicnaCijena;
        private System.Windows.Forms.TextBox tbJedinicnaCijenaKS;
        private System.Windows.Forms.Label lbNazivKS;
        private System.Windows.Forms.TextBox tbNazivKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSifraKomponenteKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazivKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCijenaPoKomaduKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDostupnaKolicinaKS;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnOznaci;
    }
}