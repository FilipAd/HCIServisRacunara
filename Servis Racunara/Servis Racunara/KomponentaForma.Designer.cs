
namespace Servis_Racunara
{
    partial class KomponentaForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKomponenta = new System.Windows.Forms.DataGridView();
            this.ColumnSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDostupnaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIzmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnObrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDodaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbDodavanjeKomponente = new System.Windows.Forms.GroupBox();
            this.btDodajKolicinu = new System.Windows.Forms.Button();
            this.btSacuvajIzmjeneKomponenta = new System.Windows.Forms.Button();
            this.tbSifraKomponente = new System.Windows.Forms.TextBox();
            this.lbSifraKomponente = new System.Windows.Forms.Label();
            this.btDodajKomponentu = new System.Windows.Forms.Button();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.lbKolicina = new System.Windows.Forms.Label();
            this.tbCijenaPoKomadu = new System.Windows.Forms.TextBox();
            this.lbCijenaPoKomadu = new System.Windows.Forms.Label();
            this.tbNazivKomponente = new System.Windows.Forms.TextBox();
            this.lbNazivKomponente = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponenta)).BeginInit();
            this.gbDodavanjeKomponente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKomponenta
            // 
            this.dgvKomponenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomponenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKomponenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSifra,
            this.ColumnNaziv,
            this.ColumnCijena,
            this.ColumnDostupnaKolicina,
            this.ColumnIzmjeni,
            this.ColumnObrisi,
            this.ColumnDodaj});
            this.dgvKomponenta.Location = new System.Drawing.Point(26, 39);
            this.dgvKomponenta.Name = "dgvKomponenta";
            this.dgvKomponenta.Size = new System.Drawing.Size(978, 226);
            this.dgvKomponenta.TabIndex = 0;
            this.dgvKomponenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomponenta_CellContentClick);
            // 
            // ColumnSifra
            // 
            this.ColumnSifra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSifra.HeaderText = "Sifra";
            this.ColumnSifra.Name = "ColumnSifra";
            this.ColumnSifra.ReadOnly = true;
            // 
            // ColumnNaziv
            // 
            this.ColumnNaziv.HeaderText = "Naziv";
            this.ColumnNaziv.Name = "ColumnNaziv";
            this.ColumnNaziv.ReadOnly = true;
            // 
            // ColumnCijena
            // 
            this.ColumnCijena.HeaderText = "Cijena po komadu";
            this.ColumnCijena.Name = "ColumnCijena";
            this.ColumnCijena.ReadOnly = true;
            // 
            // ColumnDostupnaKolicina
            // 
            this.ColumnDostupnaKolicina.HeaderText = "Dostupna kolicina";
            this.ColumnDostupnaKolicina.Name = "ColumnDostupnaKolicina";
            this.ColumnDostupnaKolicina.ReadOnly = true;
            // 
            // ColumnIzmjeni
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnIzmjeni.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnIzmjeni.HeaderText = "Izmjeni";
            this.ColumnIzmjeni.Name = "ColumnIzmjeni";
            this.ColumnIzmjeni.Text = "Izmjeni";
            this.ColumnIzmjeni.UseColumnTextForButtonValue = true;
            // 
            // ColumnObrisi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnObrisi.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnObrisi.HeaderText = "Obrisi";
            this.ColumnObrisi.Name = "ColumnObrisi";
            this.ColumnObrisi.Text = "Obrisi";
            this.ColumnObrisi.UseColumnTextForButtonValue = true;
            // 
            // ColumnDodaj
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnDodaj.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnDodaj.HeaderText = "Dodaj";
            this.ColumnDodaj.Name = "ColumnDodaj";
            this.ColumnDodaj.Text = "Dodaj";
            this.ColumnDodaj.UseColumnTextForButtonValue = true;
            // 
            // gbDodavanjeKomponente
            // 
            this.gbDodavanjeKomponente.Controls.Add(this.btDodajKolicinu);
            this.gbDodavanjeKomponente.Controls.Add(this.btSacuvajIzmjeneKomponenta);
            this.gbDodavanjeKomponente.Controls.Add(this.tbSifraKomponente);
            this.gbDodavanjeKomponente.Controls.Add(this.lbSifraKomponente);
            this.gbDodavanjeKomponente.Controls.Add(this.btDodajKomponentu);
            this.gbDodavanjeKomponente.Controls.Add(this.tbKolicina);
            this.gbDodavanjeKomponente.Controls.Add(this.lbKolicina);
            this.gbDodavanjeKomponente.Controls.Add(this.tbCijenaPoKomadu);
            this.gbDodavanjeKomponente.Controls.Add(this.lbCijenaPoKomadu);
            this.gbDodavanjeKomponente.Controls.Add(this.tbNazivKomponente);
            this.gbDodavanjeKomponente.Controls.Add(this.lbNazivKomponente);
            this.gbDodavanjeKomponente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDodavanjeKomponente.Location = new System.Drawing.Point(559, 313);
            this.gbDodavanjeKomponente.Name = "gbDodavanjeKomponente";
            this.gbDodavanjeKomponente.Size = new System.Drawing.Size(445, 222);
            this.gbDodavanjeKomponente.TabIndex = 1;
            this.gbDodavanjeKomponente.TabStop = false;
            this.gbDodavanjeKomponente.Text = "DODAVANJE KOMPONENTE";
            this.gbDodavanjeKomponente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btDodajKolicinu
            // 
            this.btDodajKolicinu.Enabled = false;
            this.btDodajKolicinu.Location = new System.Drawing.Point(303, 98);
            this.btDodajKolicinu.Name = "btDodajKolicinu";
            this.btDodajKolicinu.Size = new System.Drawing.Size(125, 54);
            this.btDodajKolicinu.TabIndex = 10;
            this.btDodajKolicinu.Text = "DODAJ NA POSTOJECU KOLICINU";
            this.btDodajKolicinu.UseVisualStyleBackColor = true;
            this.btDodajKolicinu.Click += new System.EventHandler(this.btDodajKolicinu_Click);
            // 
            // btSacuvajIzmjeneKomponenta
            // 
            this.btSacuvajIzmjeneKomponenta.Enabled = false;
            this.btSacuvajIzmjeneKomponenta.Location = new System.Drawing.Point(303, 33);
            this.btSacuvajIzmjeneKomponenta.Name = "btSacuvajIzmjeneKomponenta";
            this.btSacuvajIzmjeneKomponenta.Size = new System.Drawing.Size(125, 43);
            this.btSacuvajIzmjeneKomponenta.TabIndex = 9;
            this.btSacuvajIzmjeneKomponenta.Text = "SACUVAJ IZMJENE";
            this.btSacuvajIzmjeneKomponenta.UseVisualStyleBackColor = true;
            this.btSacuvajIzmjeneKomponenta.Click += new System.EventHandler(this.btSacuvajIzmjeneKomponenta_Click);
            // 
            // tbSifraKomponente
            // 
            this.tbSifraKomponente.Location = new System.Drawing.Point(34, 44);
            this.tbSifraKomponente.Name = "tbSifraKomponente";
            this.tbSifraKomponente.Size = new System.Drawing.Size(179, 21);
            this.tbSifraKomponente.TabIndex = 8;
            // 
            // lbSifraKomponente
            // 
            this.lbSifraKomponente.AutoSize = true;
            this.lbSifraKomponente.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSifraKomponente.Location = new System.Drawing.Point(30, 21);
            this.lbSifraKomponente.Name = "lbSifraKomponente";
            this.lbSifraKomponente.Size = new System.Drawing.Size(139, 20);
            this.lbSifraKomponente.TabIndex = 7;
            this.lbSifraKomponente.Text = "Sifra komponente:";
            // 
            // btDodajKomponentu
            // 
            this.btDodajKomponentu.Location = new System.Drawing.Point(303, 178);
            this.btDodajKomponentu.Name = "btDodajKomponentu";
            this.btDodajKomponentu.Size = new System.Drawing.Size(125, 32);
            this.btDodajKomponentu.TabIndex = 6;
            this.btDodajKomponentu.Text = "DODAJ";
            this.btDodajKomponentu.UseVisualStyleBackColor = true;
            this.btDodajKomponentu.Click += new System.EventHandler(this.btDodajKomponentu_Click);
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(34, 184);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(179, 21);
            this.tbKolicina.TabIndex = 5;
            // 
            // lbKolicina
            // 
            this.lbKolicina.AutoSize = true;
            this.lbKolicina.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKolicina.Location = new System.Drawing.Point(30, 161);
            this.lbKolicina.Name = "lbKolicina";
            this.lbKolicina.Size = new System.Drawing.Size(73, 20);
            this.lbKolicina.TabIndex = 4;
            this.lbKolicina.Text = "Kolicina:";
            // 
            // tbCijenaPoKomadu
            // 
            this.tbCijenaPoKomadu.Location = new System.Drawing.Point(34, 137);
            this.tbCijenaPoKomadu.Name = "tbCijenaPoKomadu";
            this.tbCijenaPoKomadu.Size = new System.Drawing.Size(179, 21);
            this.tbCijenaPoKomadu.TabIndex = 3;
            // 
            // lbCijenaPoKomadu
            // 
            this.lbCijenaPoKomadu.AutoSize = true;
            this.lbCijenaPoKomadu.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCijenaPoKomadu.Location = new System.Drawing.Point(30, 114);
            this.lbCijenaPoKomadu.Name = "lbCijenaPoKomadu";
            this.lbCijenaPoKomadu.Size = new System.Drawing.Size(145, 20);
            this.lbCijenaPoKomadu.TabIndex = 2;
            this.lbCijenaPoKomadu.Text = "Cijena po komadu:";
            // 
            // tbNazivKomponente
            // 
            this.tbNazivKomponente.Location = new System.Drawing.Point(34, 90);
            this.tbNazivKomponente.Name = "tbNazivKomponente";
            this.tbNazivKomponente.Size = new System.Drawing.Size(179, 21);
            this.tbNazivKomponente.TabIndex = 1;
            // 
            // lbNazivKomponente
            // 
            this.lbNazivKomponente.AutoSize = true;
            this.lbNazivKomponente.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNazivKomponente.Location = new System.Drawing.Point(30, 67);
            this.lbNazivKomponente.Name = "lbNazivKomponente";
            this.lbNazivKomponente.Size = new System.Drawing.Size(150, 20);
            this.lbNazivKomponente.TabIndex = 0;
            this.lbNazivKomponente.Text = "Naziv komponente:";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(728, 13);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(276, 20);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(456, 13);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(187, 21);
            this.lbFilter.TabIndex = 3;
            this.lbFilter.Text = "Pretraga( sifra ili naziv ):";
            // 
            // KomponentaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 547);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.gbDodavanjeKomponente);
            this.Controls.Add(this.dgvKomponenta);
            this.Name = "KomponentaForma";
            this.Text = "KomponentaForma";
            this.Load += new System.EventHandler(this.KomponentaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponenta)).EndInit();
            this.gbDodavanjeKomponente.ResumeLayout(false);
            this.gbDodavanjeKomponente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKomponenta;
        private System.Windows.Forms.GroupBox gbDodavanjeKomponente;
        private System.Windows.Forms.Button btDodajKomponentu;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label lbKolicina;
        private System.Windows.Forms.TextBox tbCijenaPoKomadu;
        private System.Windows.Forms.Label lbCijenaPoKomadu;
        private System.Windows.Forms.TextBox tbNazivKomponente;
        private System.Windows.Forms.Label lbNazivKomponente;
        private System.Windows.Forms.TextBox tbSifraKomponente;
        private System.Windows.Forms.Label lbSifraKomponente;
        private System.Windows.Forms.Button btSacuvajIzmjeneKomponenta;
        private System.Windows.Forms.Button btDodajKolicinu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDostupnaKolicina;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnIzmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnObrisi;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDodaj;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lbFilter;
    }
}