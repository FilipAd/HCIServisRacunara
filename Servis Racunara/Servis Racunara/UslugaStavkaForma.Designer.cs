
namespace Servis_Racunara
{
    partial class UslugaStavkaForma
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
            this.dgvUsluga = new System.Windows.Forms.DataGridView();
            this.ColumnSifraUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazivUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCijenaPoH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOznaci = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbBrojNalogaUslugaStavka = new System.Windows.Forms.Label();
            this.lbSifraUsluge = new System.Windows.Forms.Label();
            this.lbNazivUsluge = new System.Windows.Forms.Label();
            this.lbCijenaUslugePoH = new System.Windows.Forms.Label();
            this.tbBrojNalogaUS = new System.Windows.Forms.TextBox();
            this.tbSifraUS = new System.Windows.Forms.TextBox();
            this.tbNazivUS = new System.Windows.Forms.TextBox();
            this.tbCijenaPoSatuUS = new System.Windows.Forms.TextBox();
            this.lbKolicinaUsluge = new System.Windows.Forms.Label();
            this.tbKolicinaUS = new System.Windows.Forms.TextBox();
            this.lbRabatUsluga = new System.Windows.Forms.Label();
            this.tbRabatUS = new System.Windows.Forms.TextBox();
            this.lbCijenaUslugeZavrsna = new System.Windows.Forms.Label();
            this.tbCijenaUS = new System.Windows.Forms.TextBox();
            this.gbUslugaStavka = new System.Windows.Forms.GroupBox();
            this.btDodajUsluguNaNalog = new System.Windows.Forms.Button();
            this.lbFilterUsluga = new System.Windows.Forms.Label();
            this.tbFilterUsluga = new System.Windows.Forms.TextBox();
            this.btIzracunajCijenuUS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluga)).BeginInit();
            this.gbUslugaStavka.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsluga
            // 
            this.dgvUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSifraUsluge,
            this.ColumnNazivUsluge,
            this.ColumnCijenaPoH,
            this.ColumnOznaci});
            this.dgvUsluga.Location = new System.Drawing.Point(11, 30);
            this.dgvUsluga.Name = "dgvUsluga";
            this.dgvUsluga.Size = new System.Drawing.Size(713, 292);
            this.dgvUsluga.TabIndex = 0;
            this.dgvUsluga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsluga_CellContentClick);
            // 
            // ColumnSifraUsluge
            // 
            this.ColumnSifraUsluge.HeaderText = "Sifra";
            this.ColumnSifraUsluge.Name = "ColumnSifraUsluge";
            // 
            // ColumnNazivUsluge
            // 
            this.ColumnNazivUsluge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNazivUsluge.HeaderText = "Naziv";
            this.ColumnNazivUsluge.Name = "ColumnNazivUsluge";
            // 
            // ColumnCijenaPoH
            // 
            this.ColumnCijenaPoH.HeaderText = "Cijena po h";
            this.ColumnCijenaPoH.Name = "ColumnCijenaPoH";
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
            // lbBrojNalogaUslugaStavka
            // 
            this.lbBrojNalogaUslugaStavka.AutoSize = true;
            this.lbBrojNalogaUslugaStavka.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojNalogaUslugaStavka.Location = new System.Drawing.Point(24, 420);
            this.lbBrojNalogaUslugaStavka.Name = "lbBrojNalogaUslugaStavka";
            this.lbBrojNalogaUslugaStavka.Size = new System.Drawing.Size(133, 21);
            this.lbBrojNalogaUslugaStavka.TabIndex = 1;
            this.lbBrojNalogaUslugaStavka.Text = "BROJ NALOGA:";
            // 
            // lbSifraUsluge
            // 
            this.lbSifraUsluge.AutoSize = true;
            this.lbSifraUsluge.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSifraUsluge.Location = new System.Drawing.Point(24, 458);
            this.lbSifraUsluge.Name = "lbSifraUsluge";
            this.lbSifraUsluge.Size = new System.Drawing.Size(63, 21);
            this.lbSifraUsluge.TabIndex = 2;
            this.lbSifraUsluge.Text = "SIFRA:";
            // 
            // lbNazivUsluge
            // 
            this.lbNazivUsluge.AutoSize = true;
            this.lbNazivUsluge.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNazivUsluge.Location = new System.Drawing.Point(24, 493);
            this.lbNazivUsluge.Name = "lbNazivUsluge";
            this.lbNazivUsluge.Size = new System.Drawing.Size(68, 21);
            this.lbNazivUsluge.TabIndex = 3;
            this.lbNazivUsluge.Text = "NAZIV:";
            // 
            // lbCijenaUslugePoH
            // 
            this.lbCijenaUslugePoH.AutoSize = true;
            this.lbCijenaUslugePoH.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCijenaUslugePoH.Location = new System.Drawing.Point(24, 522);
            this.lbCijenaUslugePoH.Name = "lbCijenaUslugePoH";
            this.lbCijenaUslugePoH.Size = new System.Drawing.Size(149, 21);
            this.lbCijenaUslugePoH.TabIndex = 4;
            this.lbCijenaUslugePoH.Text = "CIJENA PO SATU:";
            // 
            // tbBrojNalogaUS
            // 
            this.tbBrojNalogaUS.Location = new System.Drawing.Point(249, 421);
            this.tbBrojNalogaUS.Name = "tbBrojNalogaUS";
            this.tbBrojNalogaUS.ReadOnly = true;
            this.tbBrojNalogaUS.Size = new System.Drawing.Size(175, 20);
            this.tbBrojNalogaUS.TabIndex = 5;
            this.tbBrojNalogaUS.TextChanged += new System.EventHandler(this.tbBrojNalogaUS_TextChanged);
            // 
            // tbSifraUS
            // 
            this.tbSifraUS.Location = new System.Drawing.Point(190, 460);
            this.tbSifraUS.Name = "tbSifraUS";
            this.tbSifraUS.ReadOnly = true;
            this.tbSifraUS.Size = new System.Drawing.Size(234, 20);
            this.tbSifraUS.TabIndex = 6;
            // 
            // tbNazivUS
            // 
            this.tbNazivUS.Location = new System.Drawing.Point(190, 494);
            this.tbNazivUS.Name = "tbNazivUS";
            this.tbNazivUS.ReadOnly = true;
            this.tbNazivUS.Size = new System.Drawing.Size(234, 20);
            this.tbNazivUS.TabIndex = 7;
            // 
            // tbCijenaPoSatuUS
            // 
            this.tbCijenaPoSatuUS.Location = new System.Drawing.Point(266, 524);
            this.tbCijenaPoSatuUS.Name = "tbCijenaPoSatuUS";
            this.tbCijenaPoSatuUS.ReadOnly = true;
            this.tbCijenaPoSatuUS.Size = new System.Drawing.Size(158, 20);
            this.tbCijenaPoSatuUS.TabIndex = 8;
            // 
            // lbKolicinaUsluge
            // 
            this.lbKolicinaUsluge.AutoSize = true;
            this.lbKolicinaUsluge.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKolicinaUsluge.Location = new System.Drawing.Point(464, 408);
            this.lbKolicinaUsluge.Name = "lbKolicinaUsluge";
            this.lbKolicinaUsluge.Size = new System.Drawing.Size(98, 21);
            this.lbKolicinaUsluge.TabIndex = 9;
            this.lbKolicinaUsluge.Text = "KOLICINA:";
            // 
            // tbKolicinaUS
            // 
            this.tbKolicinaUS.Location = new System.Drawing.Point(614, 410);
            this.tbKolicinaUS.Name = "tbKolicinaUS";
            this.tbKolicinaUS.Size = new System.Drawing.Size(147, 20);
            this.tbKolicinaUS.TabIndex = 10;
            this.tbKolicinaUS.TextChanged += new System.EventHandler(this.tbKolicinaUS_TextChanged);
            // 
            // lbRabatUsluga
            // 
            this.lbRabatUsluga.AutoSize = true;
            this.lbRabatUsluga.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRabatUsluga.Location = new System.Drawing.Point(464, 447);
            this.lbRabatUsluga.Name = "lbRabatUsluga";
            this.lbRabatUsluga.Size = new System.Drawing.Size(104, 21);
            this.lbRabatUsluga.TabIndex = 11;
            this.lbRabatUsluga.Text = "RABAT (%) :";
            // 
            // tbRabatUS
            // 
            this.tbRabatUS.Location = new System.Drawing.Point(614, 447);
            this.tbRabatUS.Name = "tbRabatUS";
            this.tbRabatUS.Size = new System.Drawing.Size(147, 20);
            this.tbRabatUS.TabIndex = 12;
            this.tbRabatUS.TextChanged += new System.EventHandler(this.tbRabatUS_TextChanged);
            // 
            // lbCijenaUslugeZavrsna
            // 
            this.lbCijenaUslugeZavrsna.AutoSize = true;
            this.lbCijenaUslugeZavrsna.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCijenaUslugeZavrsna.Location = new System.Drawing.Point(464, 492);
            this.lbCijenaUslugeZavrsna.Name = "lbCijenaUslugeZavrsna";
            this.lbCijenaUslugeZavrsna.Size = new System.Drawing.Size(73, 21);
            this.lbCijenaUslugeZavrsna.TabIndex = 13;
            this.lbCijenaUslugeZavrsna.Text = "CIJENA:";
            // 
            // tbCijenaUS
            // 
            this.tbCijenaUS.Location = new System.Drawing.Point(614, 492);
            this.tbCijenaUS.Name = "tbCijenaUS";
            this.tbCijenaUS.ReadOnly = true;
            this.tbCijenaUS.Size = new System.Drawing.Size(147, 20);
            this.tbCijenaUS.TabIndex = 14;
            // 
            // gbUslugaStavka
            // 
            this.gbUslugaStavka.Controls.Add(this.dgvUsluga);
            this.gbUslugaStavka.Location = new System.Drawing.Point(28, 64);
            this.gbUslugaStavka.Name = "gbUslugaStavka";
            this.gbUslugaStavka.Size = new System.Drawing.Size(733, 328);
            this.gbUslugaStavka.TabIndex = 15;
            this.gbUslugaStavka.TabStop = false;
            this.gbUslugaStavka.Text = "USLUGE:";
            this.gbUslugaStavka.Enter += new System.EventHandler(this.gbUslugaStavka_Enter);
            // 
            // btDodajUsluguNaNalog
            // 
            this.btDodajUsluguNaNalog.BackColor = System.Drawing.Color.Turquoise;
            this.btDodajUsluguNaNalog.Enabled = false;
            this.btDodajUsluguNaNalog.Location = new System.Drawing.Point(482, 533);
            this.btDodajUsluguNaNalog.Name = "btDodajUsluguNaNalog";
            this.btDodajUsluguNaNalog.Size = new System.Drawing.Size(127, 49);
            this.btDodajUsluguNaNalog.TabIndex = 16;
            this.btDodajUsluguNaNalog.Text = "DODAJ NA NALOG";
            this.btDodajUsluguNaNalog.UseVisualStyleBackColor = false;
            this.btDodajUsluguNaNalog.Click += new System.EventHandler(this.btDodajUsluguNaNalog_Click);
            // 
            // lbFilterUsluga
            // 
            this.lbFilterUsluga.AutoSize = true;
            this.lbFilterUsluga.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterUsluga.Location = new System.Drawing.Point(387, 32);
            this.lbFilterUsluga.Name = "lbFilterUsluga";
            this.lbFilterUsluga.Size = new System.Drawing.Size(70, 21);
            this.lbFilterUsluga.TabIndex = 17;
            this.lbFilterUsluga.Text = "Pretrazi:";
            // 
            // tbFilterUsluga
            // 
            this.tbFilterUsluga.Location = new System.Drawing.Point(522, 32);
            this.tbFilterUsluga.Name = "tbFilterUsluga";
            this.tbFilterUsluga.Size = new System.Drawing.Size(239, 20);
            this.tbFilterUsluga.TabIndex = 18;
            this.tbFilterUsluga.TextChanged += new System.EventHandler(this.tbFilterUsluga_TextChanged);
            // 
            // btIzracunajCijenuUS
            // 
            this.btIzracunajCijenuUS.BackColor = System.Drawing.Color.Coral;
            this.btIzracunajCijenuUS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btIzracunajCijenuUS.Location = new System.Drawing.Point(638, 533);
            this.btIzracunajCijenuUS.Name = "btIzracunajCijenuUS";
            this.btIzracunajCijenuUS.Size = new System.Drawing.Size(114, 49);
            this.btIzracunajCijenuUS.TabIndex = 19;
            this.btIzracunajCijenuUS.Text = "OBRACUNAJ";
            this.btIzracunajCijenuUS.UseVisualStyleBackColor = false;
            this.btIzracunajCijenuUS.Click += new System.EventHandler(this.btIzracunajCijenuUS_Click);
            // 
            // UslugaStavkaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.btIzracunajCijenuUS);
            this.Controls.Add(this.tbFilterUsluga);
            this.Controls.Add(this.lbFilterUsluga);
            this.Controls.Add(this.btDodajUsluguNaNalog);
            this.Controls.Add(this.gbUslugaStavka);
            this.Controls.Add(this.tbCijenaUS);
            this.Controls.Add(this.lbCijenaUslugeZavrsna);
            this.Controls.Add(this.tbRabatUS);
            this.Controls.Add(this.lbRabatUsluga);
            this.Controls.Add(this.tbKolicinaUS);
            this.Controls.Add(this.lbKolicinaUsluge);
            this.Controls.Add(this.tbCijenaPoSatuUS);
            this.Controls.Add(this.tbNazivUS);
            this.Controls.Add(this.tbSifraUS);
            this.Controls.Add(this.tbBrojNalogaUS);
            this.Controls.Add(this.lbCijenaUslugePoH);
            this.Controls.Add(this.lbNazivUsluge);
            this.Controls.Add(this.lbSifraUsluge);
            this.Controls.Add(this.lbBrojNalogaUslugaStavka);
            this.Name = "UslugaStavkaForma";
            this.Text = "UslugaStavka";
            this.Load += new System.EventHandler(this.UslugaStavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluga)).EndInit();
            this.gbUslugaStavka.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsluga;
        private System.Windows.Forms.Label lbBrojNalogaUslugaStavka;
        private System.Windows.Forms.Label lbSifraUsluge;
        private System.Windows.Forms.Label lbNazivUsluge;
        private System.Windows.Forms.Label lbCijenaUslugePoH;
        private System.Windows.Forms.TextBox tbBrojNalogaUS;
        private System.Windows.Forms.TextBox tbSifraUS;
        private System.Windows.Forms.TextBox tbNazivUS;
        private System.Windows.Forms.TextBox tbCijenaPoSatuUS;
        private System.Windows.Forms.Label lbKolicinaUsluge;
        private System.Windows.Forms.TextBox tbKolicinaUS;
        private System.Windows.Forms.Label lbRabatUsluga;
        private System.Windows.Forms.TextBox tbRabatUS;
        private System.Windows.Forms.Label lbCijenaUslugeZavrsna;
        private System.Windows.Forms.TextBox tbCijenaUS;
        private System.Windows.Forms.GroupBox gbUslugaStavka;
        private System.Windows.Forms.Button btDodajUsluguNaNalog;
        private System.Windows.Forms.Label lbFilterUsluga;
        private System.Windows.Forms.TextBox tbFilterUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSifraUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazivUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCijenaPoH;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnOznaci;
        private System.Windows.Forms.Button btIzracunajCijenuUS;
    }
}