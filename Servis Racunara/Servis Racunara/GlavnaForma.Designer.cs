
namespace Servis_Racunara
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbZahtjev = new System.Windows.Forms.TextBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDatumKreiranja = new System.Windows.Forms.Label();
            this.lbDatumZavrsetka = new System.Windows.Forms.Label();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.lbNapomena = new System.Windows.Forms.Label();
            this.rbNeproknjizeni = new System.Windows.Forms.RadioButton();
            this.rbProknjizeni = new System.Windows.Forms.RadioButton();
            this.tcNalozi = new System.Windows.Forms.TabControl();
            this.tabPageNeproknjizeni = new System.Windows.Forms.TabPage();
            this.dgvNeproknjizeni = new System.Windows.Forms.DataGridView();
            this.ColumnBrojNaloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumKreiranjaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImeKlijentaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdPartnera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProknjizeni = new System.Windows.Forms.TabPage();
            this.dgvProknjizeni = new System.Windows.Forms.DataGridView();
            this.ColumnBrojNalogaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumKreiranjaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdPartneraProknjizeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSacuvajIzmjene = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbKlijent = new System.Windows.Forms.Label();
            this.tbKlijentGF = new System.Windows.Forms.TextBox();
            this.tcUslugaKomponenta = new System.Windows.Forms.TabControl();
            this.tabPageUsluga = new System.Windows.Forms.TabPage();
            this.dgvUslugaStavka = new System.Windows.Forms.DataGridView();
            this.ColumnSifraUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazivUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKolicinaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIzmjeniStavkuUsluge = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnObrisiStavkuUsluge = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageKomponenta = new System.Windows.Forms.TabPage();
            this.dgvKomponentaStavka = new System.Windows.Forms.DataGridView();
            this.ColumnSifraKomponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazivKomponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKolicinaKomponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCijenaKomponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRabatKomponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUkupnaCijenaKomponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIzmjeniKS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnObrisiKS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btIzmjenaNaloga = new System.Windows.Forms.Button();
            this.btNoviRadniNalog = new System.Windows.Forms.Button();
            this.lbBrRadnogNaloga = new System.Windows.Forms.Label();
            this.tbBrojRadnogNaloga = new System.Windows.Forms.TextBox();
            this.lbIdKlijenta = new System.Windows.Forms.Label();
            this.tbIdKlijentaGF = new System.Windows.Forms.TextBox();
            this.lbZaprimio = new System.Windows.Forms.Label();
            this.lbServiserRadi = new System.Windows.Forms.Label();
            this.cbZaprimio = new System.Windows.Forms.ComboBox();
            this.cbRadi = new System.Windows.Forms.ComboBox();
            this.btSacuvajNalog = new System.Windows.Forms.Button();
            this.btDodajUslugu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbPretraziNalog = new System.Windows.Forms.Label();
            this.tbFilterNalog = new System.Windows.Forms.TextBox();
            this.lbUkupnoUsluge = new System.Windows.Forms.Label();
            this.lbVrUsluge = new System.Windows.Forms.Label();
            this.lbUkupnoKomponenti = new System.Windows.Forms.Label();
            this.gbPlacanje = new System.Windows.Forms.GroupBox();
            this.lbVrUkupno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbVrKomponente = new System.Windows.Forms.Label();
            this.btOsvjeziUsluguKomponente = new System.Windows.Forms.Button();
            this.btnKomponenta = new System.Windows.Forms.Button();
            this.btnSubjekat = new System.Windows.Forms.Button();
            this.btObrisiNalog = new System.Windows.Forms.Button();
            this.btProknjizi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcNalozi.SuspendLayout();
            this.tabPageNeproknjizeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeproknjizeni)).BeginInit();
            this.tabPageProknjizeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProknjizeni)).BeginInit();
            this.tcUslugaKomponenta.SuspendLayout();
            this.tabPageUsluga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUslugaStavka)).BeginInit();
            this.tabPageKomponenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponentaStavka)).BeginInit();
            this.gbPlacanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ZAHTJEV:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbZahtjev
            // 
            this.tbZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZahtjev.Location = new System.Drawing.Point(585, 155);
            this.tbZahtjev.Multiline = true;
            this.tbZahtjev.Name = "tbZahtjev";
            this.tbZahtjev.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbZahtjev.Size = new System.Drawing.Size(462, 99);
            this.tbZahtjev.TabIndex = 5;
            this.tbZahtjev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNapomena
            // 
            this.tbNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNapomena.Location = new System.Drawing.Point(591, 550);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNapomena.Size = new System.Drawing.Size(431, 152);
            this.tbNapomena.TabIndex = 0;
            this.tbNapomena.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(585, 281);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(204, 20);
            this.dtpDatumKreiranja.TabIndex = 7;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "ZAHTJEV ZA SERVISOM",
            "RADI SE",
            "ZAVRSENO"});
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cbStatus.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ZAHTJEV ZA SERVISOM",
            "RADI SE",
            "ZAVRSEN"});
            this.cbStatus.Location = new System.Drawing.Point(585, 99);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(271, 25);
            this.cbStatus.TabIndex = 8;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(581, 72);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(80, 21);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "STATUS:";
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // lbDatumKreiranja
            // 
            this.lbDatumKreiranja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatumKreiranja.AutoSize = true;
            this.lbDatumKreiranja.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumKreiranja.Location = new System.Drawing.Point(582, 261);
            this.lbDatumKreiranja.Name = "lbDatumKreiranja";
            this.lbDatumKreiranja.Size = new System.Drawing.Size(106, 17);
            this.lbDatumKreiranja.TabIndex = 10;
            this.lbDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lbDatumZavrsetka
            // 
            this.lbDatumZavrsetka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatumZavrsetka.AutoSize = true;
            this.lbDatumZavrsetka.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumZavrsetka.Location = new System.Drawing.Point(943, 261);
            this.lbDatumZavrsetka.Name = "lbDatumZavrsetka";
            this.lbDatumZavrsetka.Size = new System.Drawing.Size(110, 17);
            this.lbDatumZavrsetka.TabIndex = 11;
            this.lbDatumZavrsetka.Text = "Datum zavrsetka:";
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(857, 281);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(190, 20);
            this.dtpDatumZavrsetka.TabIndex = 12;
            this.dtpDatumZavrsetka.ValueChanged += new System.EventHandler(this.dtpDatumZavrsetka_ValueChanged);
            // 
            // lbNapomena
            // 
            this.lbNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNapomena.AutoSize = true;
            this.lbNapomena.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNapomena.Location = new System.Drawing.Point(587, 526);
            this.lbNapomena.Name = "lbNapomena";
            this.lbNapomena.Size = new System.Drawing.Size(113, 21);
            this.lbNapomena.TabIndex = 13;
            this.lbNapomena.Text = "NAPOMENA:";
            // 
            // rbNeproknjizeni
            // 
            this.rbNeproknjizeni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNeproknjizeni.AutoSize = true;
            this.rbNeproknjizeni.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNeproknjizeni.Location = new System.Drawing.Point(183, 458);
            this.rbNeproknjizeni.Name = "rbNeproknjizeni";
            this.rbNeproknjizeni.Size = new System.Drawing.Size(232, 25);
            this.rbNeproknjizeni.TabIndex = 14;
            this.rbNeproknjizeni.TabStop = true;
            this.rbNeproknjizeni.Text = "NEPROKNJIZENI NALOZI";
            this.rbNeproknjizeni.UseVisualStyleBackColor = true;
            this.rbNeproknjizeni.CheckedChanged += new System.EventHandler(this.rbNeproknjizeni_CheckedChanged);
            // 
            // rbProknjizeni
            // 
            this.rbProknjizeni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbProknjizeni.AutoSize = true;
            this.rbProknjizeni.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProknjizeni.Location = new System.Drawing.Point(183, 489);
            this.rbProknjizeni.Name = "rbProknjizeni";
            this.rbProknjizeni.Size = new System.Drawing.Size(209, 25);
            this.rbProknjizeni.TabIndex = 15;
            this.rbProknjizeni.TabStop = true;
            this.rbProknjizeni.Text = "PROKNJIZENI NALOZI";
            this.rbProknjizeni.UseVisualStyleBackColor = true;
            this.rbProknjizeni.CheckedChanged += new System.EventHandler(this.rbProknjizeni_CheckedChanged);
            // 
            // tcNalozi
            // 
            this.tcNalozi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcNalozi.Controls.Add(this.tabPageNeproknjizeni);
            this.tcNalozi.Controls.Add(this.tabPageProknjizeni);
            this.tcNalozi.Location = new System.Drawing.Point(8, 131);
            this.tcNalozi.Multiline = true;
            this.tcNalozi.Name = "tcNalozi";
            this.tcNalozi.SelectedIndex = 0;
            this.tcNalozi.Size = new System.Drawing.Size(550, 300);
            this.tcNalozi.TabIndex = 16;
            this.tcNalozi.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcNalozi_Selected);
            // 
            // tabPageNeproknjizeni
            // 
            this.tabPageNeproknjizeni.Controls.Add(this.dgvNeproknjizeni);
            this.tabPageNeproknjizeni.Location = new System.Drawing.Point(4, 22);
            this.tabPageNeproknjizeni.Name = "tabPageNeproknjizeni";
            this.tabPageNeproknjizeni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNeproknjizeni.Size = new System.Drawing.Size(542, 274);
            this.tabPageNeproknjizeni.TabIndex = 0;
            this.tabPageNeproknjizeni.Text = "Neproknjizeni";
            this.tabPageNeproknjizeni.UseVisualStyleBackColor = true;
            // 
            // dgvNeproknjizeni
            // 
            this.dgvNeproknjizeni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNeproknjizeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeproknjizeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBrojNaloga,
            this.ColumnDatumKreiranjaN,
            this.ColumnImeKlijentaN,
            this.ColumnStatusN,
            this.ColumnIdPartnera});
            this.dgvNeproknjizeni.Location = new System.Drawing.Point(0, 0);
            this.dgvNeproknjizeni.Name = "dgvNeproknjizeni";
            this.dgvNeproknjizeni.Size = new System.Drawing.Size(542, 284);
            this.dgvNeproknjizeni.TabIndex = 0;
            this.dgvNeproknjizeni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNeproknjizeni_CellContentClick);
            // 
            // ColumnBrojNaloga
            // 
            this.ColumnBrojNaloga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnBrojNaloga.HeaderText = "Br.Naloga";
            this.ColumnBrojNaloga.Name = "ColumnBrojNaloga";
            this.ColumnBrojNaloga.Width = 40;
            // 
            // ColumnDatumKreiranjaN
            // 
            this.ColumnDatumKreiranjaN.HeaderText = "DatumKreiranja";
            this.ColumnDatumKreiranjaN.Name = "ColumnDatumKreiranjaN";
            // 
            // ColumnImeKlijentaN
            // 
            this.ColumnImeKlijentaN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnImeKlijentaN.HeaderText = "Ime";
            this.ColumnImeKlijentaN.MinimumWidth = 100;
            this.ColumnImeKlijentaN.Name = "ColumnImeKlijentaN";
            // 
            // ColumnStatusN
            // 
            this.ColumnStatusN.HeaderText = "Status";
            this.ColumnStatusN.Name = "ColumnStatusN";
            // 
            // ColumnIdPartnera
            // 
            this.ColumnIdPartnera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnIdPartnera.HeaderText = "IdPartnera";
            this.ColumnIdPartnera.Name = "ColumnIdPartnera";
            this.ColumnIdPartnera.Width = 40;
            // 
            // tabPageProknjizeni
            // 
            this.tabPageProknjizeni.Controls.Add(this.dgvProknjizeni);
            this.tabPageProknjizeni.Location = new System.Drawing.Point(4, 22);
            this.tabPageProknjizeni.Name = "tabPageProknjizeni";
            this.tabPageProknjizeni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProknjizeni.Size = new System.Drawing.Size(542, 274);
            this.tabPageProknjizeni.TabIndex = 1;
            this.tabPageProknjizeni.Text = "Proknjizeni";
            this.tabPageProknjizeni.UseVisualStyleBackColor = true;
            this.tabPageProknjizeni.Click += new System.EventHandler(this.tpProknjizeni_Click);
            // 
            // dgvProknjizeni
            // 
            this.dgvProknjizeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProknjizeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBrojNalogaP,
            this.ColumnDatumKreiranjaP,
            this.ColumnImeP,
            this.ColumnStatusP,
            this.ColumnIdPartneraProknjizeni});
            this.dgvProknjizeni.Location = new System.Drawing.Point(0, 0);
            this.dgvProknjizeni.Name = "dgvProknjizeni";
            this.dgvProknjizeni.Size = new System.Drawing.Size(572, 424);
            this.dgvProknjizeni.TabIndex = 0;
            this.dgvProknjizeni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // ColumnBrojNalogaP
            // 
            this.ColumnBrojNalogaP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnBrojNalogaP.HeaderText = "Br.Naloga";
            this.ColumnBrojNalogaP.Name = "ColumnBrojNalogaP";
            this.ColumnBrojNalogaP.Width = 79;
            // 
            // ColumnDatumKreiranjaP
            // 
            this.ColumnDatumKreiranjaP.HeaderText = "DatumKreiranja";
            this.ColumnDatumKreiranjaP.Name = "ColumnDatumKreiranjaP";
            // 
            // ColumnImeP
            // 
            this.ColumnImeP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnImeP.HeaderText = "Ime";
            this.ColumnImeP.Name = "ColumnImeP";
            // 
            // ColumnStatusP
            // 
            this.ColumnStatusP.HeaderText = "Status";
            this.ColumnStatusP.Name = "ColumnStatusP";
            // 
            // ColumnIdPartneraProknjizeni
            // 
            this.ColumnIdPartneraProknjizeni.HeaderText = "IdPartnera";
            this.ColumnIdPartneraProknjizeni.Name = "ColumnIdPartneraProknjizeni";
            // 
            // btSacuvajIzmjene
            // 
            this.btSacuvajIzmjene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSacuvajIzmjene.Enabled = false;
            this.btSacuvajIzmjene.Location = new System.Drawing.Point(1113, 190);
            this.btSacuvajIzmjene.Name = "btSacuvajIzmjene";
            this.btSacuvajIzmjene.Size = new System.Drawing.Size(189, 53);
            this.btSacuvajIzmjene.TabIndex = 17;
            this.btSacuvajIzmjene.Text = "SACUVAJ IZMJENE";
            this.btSacuvajIzmjene.UseVisualStyleBackColor = true;
            this.btSacuvajIzmjene.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbKlijent
            // 
            this.lbKlijent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKlijent.AutoSize = true;
            this.lbKlijent.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKlijent.Location = new System.Drawing.Point(581, 13);
            this.lbKlijent.Name = "lbKlijent";
            this.lbKlijent.Size = new System.Drawing.Size(82, 21);
            this.lbKlijent.TabIndex = 20;
            this.lbKlijent.Text = "KLIJENT:";
            // 
            // tbKlijentGF
            // 
            this.tbKlijentGF.AccessibleName = "tbKlijentGF";
            this.tbKlijentGF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKlijentGF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKlijentGF.Location = new System.Drawing.Point(585, 35);
            this.tbKlijentGF.Name = "tbKlijentGF";
            this.tbKlijentGF.ReadOnly = true;
            this.tbKlijentGF.Size = new System.Drawing.Size(271, 27);
            this.tbKlijentGF.TabIndex = 21;
            this.tbKlijentGF.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // tcUslugaKomponenta
            // 
            this.tcUslugaKomponenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tcUslugaKomponenta.Controls.Add(this.tabPageUsluga);
            this.tcUslugaKomponenta.Controls.Add(this.tabPageKomponenta);
            this.tcUslugaKomponenta.Location = new System.Drawing.Point(585, 308);
            this.tcUslugaKomponenta.Name = "tcUslugaKomponenta";
            this.tcUslugaKomponenta.SelectedIndex = 0;
            this.tcUslugaKomponenta.Size = new System.Drawing.Size(641, 203);
            this.tcUslugaKomponenta.TabIndex = 22;
            this.tcUslugaKomponenta.Click += new System.EventHandler(this.tcUslugaKomponenta_Click);
            // 
            // tabPageUsluga
            // 
            this.tabPageUsluga.Controls.Add(this.dgvUslugaStavka);
            this.tabPageUsluga.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsluga.Name = "tabPageUsluga";
            this.tabPageUsluga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsluga.Size = new System.Drawing.Size(633, 177);
            this.tabPageUsluga.TabIndex = 0;
            this.tabPageUsluga.Text = "USLUGA";
            this.tabPageUsluga.UseVisualStyleBackColor = true;
            // 
            // dgvUslugaStavka
            // 
            this.dgvUslugaStavka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUslugaStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUslugaStavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSifraUsluge,
            this.ColumnNazivUsluge,
            this.ColumnKolicinaUsluge,
            this.ColumnCijena,
            this.ColumnRabat,
            this.ColumnUkupnaCijena,
            this.ColumnIzmjeniStavkuUsluge,
            this.ColumnObrisiStavkuUsluge});
            this.dgvUslugaStavka.Location = new System.Drawing.Point(0, 0);
            this.dgvUslugaStavka.Name = "dgvUslugaStavka";
            this.dgvUslugaStavka.ReadOnly = true;
            this.dgvUslugaStavka.Size = new System.Drawing.Size(633, 182);
            this.dgvUslugaStavka.TabIndex = 0;
            this.dgvUslugaStavka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUslugaStavka_CellContentClick);
            // 
            // ColumnSifraUsluge
            // 
            this.ColumnSifraUsluge.HeaderText = "Sifra";
            this.ColumnSifraUsluge.Name = "ColumnSifraUsluge";
            this.ColumnSifraUsluge.ReadOnly = true;
            // 
            // ColumnNazivUsluge
            // 
            this.ColumnNazivUsluge.HeaderText = "Naziv";
            this.ColumnNazivUsluge.Name = "ColumnNazivUsluge";
            this.ColumnNazivUsluge.ReadOnly = true;
            // 
            // ColumnKolicinaUsluge
            // 
            this.ColumnKolicinaUsluge.HeaderText = "Kol";
            this.ColumnKolicinaUsluge.Name = "ColumnKolicinaUsluge";
            this.ColumnKolicinaUsluge.ReadOnly = true;
            // 
            // ColumnCijena
            // 
            this.ColumnCijena.HeaderText = "Jed.Cijena";
            this.ColumnCijena.Name = "ColumnCijena";
            this.ColumnCijena.ReadOnly = true;
            // 
            // ColumnRabat
            // 
            this.ColumnRabat.HeaderText = "Rabat";
            this.ColumnRabat.Name = "ColumnRabat";
            this.ColumnRabat.ReadOnly = true;
            // 
            // ColumnUkupnaCijena
            // 
            this.ColumnUkupnaCijena.HeaderText = "Ukupno";
            this.ColumnUkupnaCijena.Name = "ColumnUkupnaCijena";
            this.ColumnUkupnaCijena.ReadOnly = true;
            // 
            // ColumnIzmjeniStavkuUsluge
            // 
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnIzmjeniStavkuUsluge.DefaultCellStyle = dataGridViewCellStyle53;
            this.ColumnIzmjeniStavkuUsluge.HeaderText = "Izmjeni";
            this.ColumnIzmjeniStavkuUsluge.Name = "ColumnIzmjeniStavkuUsluge";
            this.ColumnIzmjeniStavkuUsluge.ReadOnly = true;
            this.ColumnIzmjeniStavkuUsluge.Text = "Izmjeni";
            this.ColumnIzmjeniStavkuUsluge.UseColumnTextForButtonValue = true;
            // 
            // ColumnObrisiStavkuUsluge
            // 
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnObrisiStavkuUsluge.DefaultCellStyle = dataGridViewCellStyle54;
            this.ColumnObrisiStavkuUsluge.HeaderText = "Obrisi";
            this.ColumnObrisiStavkuUsluge.Name = "ColumnObrisiStavkuUsluge";
            this.ColumnObrisiStavkuUsluge.ReadOnly = true;
            this.ColumnObrisiStavkuUsluge.Text = "Obrisi";
            this.ColumnObrisiStavkuUsluge.UseColumnTextForButtonValue = true;
            // 
            // tabPageKomponenta
            // 
            this.tabPageKomponenta.Controls.Add(this.dgvKomponentaStavka);
            this.tabPageKomponenta.Location = new System.Drawing.Point(4, 22);
            this.tabPageKomponenta.Name = "tabPageKomponenta";
            this.tabPageKomponenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKomponenta.Size = new System.Drawing.Size(633, 177);
            this.tabPageKomponenta.TabIndex = 1;
            this.tabPageKomponenta.Text = "KOMPONENTA";
            this.tabPageKomponenta.UseVisualStyleBackColor = true;
            // 
            // dgvKomponentaStavka
            // 
            this.dgvKomponentaStavka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKomponentaStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomponentaStavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSifraKomponente,
            this.ColumnNazivKomponente,
            this.ColumnKolicinaKomponente,
            this.ColumnCijenaKomponente,
            this.ColumnRabatKomponente,
            this.ColumnUkupnaCijenaKomponente,
            this.ColumnIzmjeniKS,
            this.ColumnObrisiKS});
            this.dgvKomponentaStavka.Location = new System.Drawing.Point(0, -1);
            this.dgvKomponentaStavka.Name = "dgvKomponentaStavka";
            this.dgvKomponentaStavka.Size = new System.Drawing.Size(633, 180);
            this.dgvKomponentaStavka.TabIndex = 0;
            this.dgvKomponentaStavka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomponentaStavka_CellContentClick);
            // 
            // ColumnSifraKomponente
            // 
            this.ColumnSifraKomponente.HeaderText = "Sifra";
            this.ColumnSifraKomponente.Name = "ColumnSifraKomponente";
            // 
            // ColumnNazivKomponente
            // 
            this.ColumnNazivKomponente.HeaderText = "Naziv";
            this.ColumnNazivKomponente.Name = "ColumnNazivKomponente";
            // 
            // ColumnKolicinaKomponente
            // 
            this.ColumnKolicinaKomponente.HeaderText = "Kol";
            this.ColumnKolicinaKomponente.Name = "ColumnKolicinaKomponente";
            // 
            // ColumnCijenaKomponente
            // 
            this.ColumnCijenaKomponente.HeaderText = "Jed.Cijena";
            this.ColumnCijenaKomponente.Name = "ColumnCijenaKomponente";
            // 
            // ColumnRabatKomponente
            // 
            this.ColumnRabatKomponente.HeaderText = "Rabat";
            this.ColumnRabatKomponente.Name = "ColumnRabatKomponente";
            // 
            // ColumnUkupnaCijenaKomponente
            // 
            this.ColumnUkupnaCijenaKomponente.HeaderText = "Ukupno";
            this.ColumnUkupnaCijenaKomponente.Name = "ColumnUkupnaCijenaKomponente";
            // 
            // ColumnIzmjeniKS
            // 
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnIzmjeniKS.DefaultCellStyle = dataGridViewCellStyle55;
            this.ColumnIzmjeniKS.HeaderText = "Izmjeni";
            this.ColumnIzmjeniKS.Name = "ColumnIzmjeniKS";
            this.ColumnIzmjeniKS.Text = "Izmjeni";
            this.ColumnIzmjeniKS.UseColumnTextForButtonValue = true;
            // 
            // ColumnObrisiKS
            // 
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnObrisiKS.DefaultCellStyle = dataGridViewCellStyle56;
            this.ColumnObrisiKS.HeaderText = "Obrisi";
            this.ColumnObrisiKS.Name = "ColumnObrisiKS";
            this.ColumnObrisiKS.Text = "Obrisi";
            this.ColumnObrisiKS.UseColumnTextForButtonValue = true;
            // 
            // btIzmjenaNaloga
            // 
            this.btIzmjenaNaloga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btIzmjenaNaloga.Location = new System.Drawing.Point(1113, 131);
            this.btIzmjenaNaloga.Name = "btIzmjenaNaloga";
            this.btIzmjenaNaloga.Size = new System.Drawing.Size(189, 53);
            this.btIzmjenaNaloga.TabIndex = 23;
            this.btIzmjenaNaloga.Text = "IZMJENA NALOGA";
            this.btIzmjenaNaloga.UseVisualStyleBackColor = true;
            this.btIzmjenaNaloga.Click += new System.EventHandler(this.btIzmjenaNaloga_Click);
            // 
            // btNoviRadniNalog
            // 
            this.btNoviRadniNalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNoviRadniNalog.Location = new System.Drawing.Point(1113, 13);
            this.btNoviRadniNalog.Name = "btNoviRadniNalog";
            this.btNoviRadniNalog.Size = new System.Drawing.Size(189, 53);
            this.btNoviRadniNalog.TabIndex = 24;
            this.btNoviRadniNalog.Text = "KREIRAJ NOVI RADNI NALOG";
            this.btNoviRadniNalog.UseVisualStyleBackColor = true;
            this.btNoviRadniNalog.Click += new System.EventHandler(this.btNoviRadniNalog_Click);
            // 
            // lbBrRadnogNaloga
            // 
            this.lbBrRadnogNaloga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBrRadnogNaloga.AutoSize = true;
            this.lbBrRadnogNaloga.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrRadnogNaloga.Location = new System.Drawing.Point(962, 72);
            this.lbBrRadnogNaloga.Name = "lbBrRadnogNaloga";
            this.lbBrRadnogNaloga.Size = new System.Drawing.Size(85, 20);
            this.lbBrRadnogNaloga.TabIndex = 26;
            this.lbBrRadnogNaloga.Text = "Br.Naloga:";
            // 
            // tbBrojRadnogNaloga
            // 
            this.tbBrojRadnogNaloga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrojRadnogNaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojRadnogNaloga.Location = new System.Drawing.Point(950, 99);
            this.tbBrojRadnogNaloga.Name = "tbBrojRadnogNaloga";
            this.tbBrojRadnogNaloga.ReadOnly = true;
            this.tbBrojRadnogNaloga.Size = new System.Drawing.Size(97, 26);
            this.tbBrojRadnogNaloga.TabIndex = 27;
            // 
            // lbIdKlijenta
            // 
            this.lbIdKlijenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIdKlijenta.AutoSize = true;
            this.lbIdKlijenta.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdKlijenta.Location = new System.Drawing.Point(961, 13);
            this.lbIdKlijenta.Name = "lbIdKlijenta";
            this.lbIdKlijenta.Size = new System.Drawing.Size(86, 20);
            this.lbIdKlijenta.TabIndex = 28;
            this.lbIdKlijenta.Text = "IDKlijenta:";
            this.lbIdKlijenta.Click += new System.EventHandler(this.lbBroj_Click);
            // 
            // tbIdKlijentaGF
            // 
            this.tbIdKlijentaGF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdKlijentaGF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdKlijentaGF.Location = new System.Drawing.Point(950, 35);
            this.tbIdKlijentaGF.Name = "tbIdKlijentaGF";
            this.tbIdKlijentaGF.ReadOnly = true;
            this.tbIdKlijentaGF.Size = new System.Drawing.Size(97, 27);
            this.tbIdKlijentaGF.TabIndex = 29;
            // 
            // lbZaprimio
            // 
            this.lbZaprimio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbZaprimio.AutoSize = true;
            this.lbZaprimio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZaprimio.Location = new System.Drawing.Point(1057, 607);
            this.lbZaprimio.Name = "lbZaprimio";
            this.lbZaprimio.Size = new System.Drawing.Size(100, 21);
            this.lbZaprimio.TabIndex = 30;
            this.lbZaprimio.Text = "ZAPRIMIO:";
            // 
            // lbServiserRadi
            // 
            this.lbServiserRadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbServiserRadi.AutoSize = true;
            this.lbServiserRadi.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiserRadi.Location = new System.Drawing.Point(1057, 657);
            this.lbServiserRadi.Name = "lbServiserRadi";
            this.lbServiserRadi.Size = new System.Drawing.Size(57, 21);
            this.lbServiserRadi.TabIndex = 31;
            this.lbServiserRadi.Text = "RADI:";
            // 
            // cbZaprimio
            // 
            this.cbZaprimio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZaprimio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbZaprimio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbZaprimio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZaprimio.FormattingEnabled = true;
            this.cbZaprimio.Location = new System.Drawing.Point(1061, 631);
            this.cbZaprimio.Name = "cbZaprimio";
            this.cbZaprimio.Size = new System.Drawing.Size(218, 23);
            this.cbZaprimio.TabIndex = 32;
            // 
            // cbRadi
            // 
            this.cbRadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRadi.FormattingEnabled = true;
            this.cbRadi.Location = new System.Drawing.Point(1061, 681);
            this.cbRadi.Name = "cbRadi";
            this.cbRadi.Size = new System.Drawing.Size(218, 21);
            this.cbRadi.TabIndex = 33;
            // 
            // btSacuvajNalog
            // 
            this.btSacuvajNalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSacuvajNalog.Enabled = false;
            this.btSacuvajNalog.Location = new System.Drawing.Point(1113, 72);
            this.btSacuvajNalog.Name = "btSacuvajNalog";
            this.btSacuvajNalog.Size = new System.Drawing.Size(189, 53);
            this.btSacuvajNalog.TabIndex = 34;
            this.btSacuvajNalog.Text = "SACUVAJ NALOG";
            this.btSacuvajNalog.UseVisualStyleBackColor = true;
            this.btSacuvajNalog.Click += new System.EventHandler(this.btSacuvajNalog_Click);
            // 
            // btDodajUslugu
            // 
            this.btDodajUslugu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDodajUslugu.AutoSize = true;
            this.btDodajUslugu.Location = new System.Drawing.Point(1232, 329);
            this.btDodajUslugu.Name = "btDodajUslugu";
            this.btDodajUslugu.Size = new System.Drawing.Size(105, 41);
            this.btDodajUslugu.TabIndex = 35;
            this.btDodajUslugu.Text = "DODAJ USLUGU";
            this.btDodajUslugu.UseVisualStyleBackColor = true;
            this.btDodajUslugu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1232, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 36;
            this.button2.Text = "DODAJ KOMPONENTU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPretraziNalog
            // 
            this.lbPretraziNalog.AutoSize = true;
            this.lbPretraziNalog.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPretraziNalog.Location = new System.Drawing.Point(258, 111);
            this.lbPretraziNalog.Name = "lbPretraziNalog";
            this.lbPretraziNalog.Size = new System.Drawing.Size(70, 21);
            this.lbPretraziNalog.TabIndex = 38;
            this.lbPretraziNalog.Text = "Pretrazi:";
            // 
            // tbFilterNalog
            // 
            this.tbFilterNalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterNalog.Location = new System.Drawing.Point(334, 113);
            this.tbFilterNalog.Name = "tbFilterNalog";
            this.tbFilterNalog.Size = new System.Drawing.Size(220, 20);
            this.tbFilterNalog.TabIndex = 39;
            this.tbFilterNalog.TextChanged += new System.EventHandler(this.tbFilterNalog_TextChanged);
            // 
            // lbUkupnoUsluge
            // 
            this.lbUkupnoUsluge.AutoSize = true;
            this.lbUkupnoUsluge.Location = new System.Drawing.Point(6, 25);
            this.lbUkupnoUsluge.Name = "lbUkupnoUsluge";
            this.lbUkupnoUsluge.Size = new System.Drawing.Size(89, 13);
            this.lbUkupnoUsluge.TabIndex = 1;
            this.lbUkupnoUsluge.Text = "Usluge za uplatu:";
            // 
            // lbVrUsluge
            // 
            this.lbVrUsluge.AutoSize = true;
            this.lbVrUsluge.Location = new System.Drawing.Point(202, 25);
            this.lbVrUsluge.Name = "lbVrUsluge";
            this.lbVrUsluge.Size = new System.Drawing.Size(28, 13);
            this.lbVrUsluge.TabIndex = 41;
            this.lbVrUsluge.Text = "0.00";
            this.lbVrUsluge.Click += new System.EventHandler(this.lbVrUsluge_Click);
            // 
            // lbUkupnoKomponenti
            // 
            this.lbUkupnoKomponenti.AutoSize = true;
            this.lbUkupnoKomponenti.Location = new System.Drawing.Point(6, 47);
            this.lbUkupnoKomponenti.Name = "lbUkupnoKomponenti";
            this.lbUkupnoKomponenti.Size = new System.Drawing.Size(94, 13);
            this.lbUkupnoKomponenti.TabIndex = 42;
            this.lbUkupnoKomponenti.Text = "Dijelova za uplatu:";
            // 
            // gbPlacanje
            // 
            this.gbPlacanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlacanje.Controls.Add(this.lbVrUkupno);
            this.gbPlacanje.Controls.Add(this.label7);
            this.gbPlacanje.Controls.Add(this.lbVrKomponente);
            this.gbPlacanje.Controls.Add(this.lbVrUsluge);
            this.gbPlacanje.Controls.Add(this.lbUkupnoKomponenti);
            this.gbPlacanje.Controls.Add(this.lbUkupnoUsluge);
            this.gbPlacanje.Location = new System.Drawing.Point(1061, 517);
            this.gbPlacanje.Name = "gbPlacanje";
            this.gbPlacanje.Size = new System.Drawing.Size(260, 87);
            this.gbPlacanje.TabIndex = 43;
            this.gbPlacanje.TabStop = false;
            this.gbPlacanje.Text = "IZNOS ZA PLACANJE:";
            // 
            // lbVrUkupno
            // 
            this.lbVrUkupno.AutoSize = true;
            this.lbVrUkupno.Location = new System.Drawing.Point(202, 69);
            this.lbVrUkupno.Name = "lbVrUkupno";
            this.lbVrUkupno.Size = new System.Drawing.Size(28, 13);
            this.lbVrUkupno.TabIndex = 45;
            this.lbVrUkupno.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "UKUPNI IZNOS ZA UPLATU";
            // 
            // lbVrKomponente
            // 
            this.lbVrKomponente.AutoSize = true;
            this.lbVrKomponente.Location = new System.Drawing.Point(202, 47);
            this.lbVrKomponente.Name = "lbVrKomponente";
            this.lbVrKomponente.Size = new System.Drawing.Size(28, 13);
            this.lbVrKomponente.TabIndex = 43;
            this.lbVrKomponente.Text = "0.00";
            // 
            // btOsvjeziUsluguKomponente
            // 
            this.btOsvjeziUsluguKomponente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOsvjeziUsluguKomponente.Image = global::Servis_Racunara.Properties.Resources.refresh__1_;
            this.btOsvjeziUsluguKomponente.Location = new System.Drawing.Point(1232, 471);
            this.btOsvjeziUsluguKomponente.Name = "btOsvjeziUsluguKomponente";
            this.btOsvjeziUsluguKomponente.Size = new System.Drawing.Size(105, 40);
            this.btOsvjeziUsluguKomponente.TabIndex = 40;
            this.btOsvjeziUsluguKomponente.UseVisualStyleBackColor = true;
            this.btOsvjeziUsluguKomponente.Click += new System.EventHandler(this.btOsvjeziUsluguKomponente_Click);
            // 
            // btnKomponenta
            // 
            this.btnKomponenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKomponenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKomponenta.Image = global::Servis_Racunara.Properties.Resources.cpu;
            this.btnKomponenta.Location = new System.Drawing.Point(167, 43);
            this.btnKomponenta.Name = "btnKomponenta";
            this.btnKomponenta.Size = new System.Drawing.Size(64, 64);
            this.btnKomponenta.TabIndex = 2;
            this.btnKomponenta.UseVisualStyleBackColor = false;
            this.btnKomponenta.Click += new System.EventHandler(this.btnKomponenta_Click);
            this.btnKomponenta.MouseHover += new System.EventHandler(this.btnKomponenta_MouseHover);
            // 
            // btnSubjekat
            // 
            this.btnSubjekat.Image = global::Servis_Racunara.Properties.Resources.users64;
            this.btnSubjekat.Location = new System.Drawing.Point(46, 43);
            this.btnSubjekat.Name = "btnSubjekat";
            this.btnSubjekat.Size = new System.Drawing.Size(64, 64);
            this.btnSubjekat.TabIndex = 1;
            this.btnSubjekat.UseVisualStyleBackColor = true;
            this.btnSubjekat.Click += new System.EventHandler(this.button1_Click);
            this.btnSubjekat.MouseHover += new System.EventHandler(this.btSubjekat_MouseHover);
            // 
            // btObrisiNalog
            // 
            this.btObrisiNalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btObrisiNalog.Location = new System.Drawing.Point(1113, 249);
            this.btObrisiNalog.Name = "btObrisiNalog";
            this.btObrisiNalog.Size = new System.Drawing.Size(189, 53);
            this.btObrisiNalog.TabIndex = 44;
            this.btObrisiNalog.Text = "OBRISI NALOG";
            this.btObrisiNalog.UseVisualStyleBackColor = true;
            this.btObrisiNalog.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btProknjizi
            // 
            this.btProknjizi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btProknjizi.Location = new System.Drawing.Point(431, 445);
            this.btProknjizi.Name = "btProknjizi";
            this.btProknjizi.Size = new System.Drawing.Size(123, 53);
            this.btProknjizi.TabIndex = 45;
            this.btProknjizi.Text = "PROKNJIZI NALOG";
            this.btProknjizi.UseVisualStyleBackColor = true;
            this.btProknjizi.Click += new System.EventHandler(this.btProknjizi_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Image = global::Servis_Racunara.Properties.Resources.refresh__1_;
            this.button1.Location = new System.Drawing.Point(8, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btProknjizi);
            this.Controls.Add(this.btObrisiNalog);
            this.Controls.Add(this.gbPlacanje);
            this.Controls.Add(this.btOsvjeziUsluguKomponente);
            this.Controls.Add(this.tbFilterNalog);
            this.Controls.Add(this.lbPretraziNalog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btDodajUslugu);
            this.Controls.Add(this.btSacuvajNalog);
            this.Controls.Add(this.cbRadi);
            this.Controls.Add(this.cbZaprimio);
            this.Controls.Add(this.lbServiserRadi);
            this.Controls.Add(this.lbZaprimio);
            this.Controls.Add(this.tbIdKlijentaGF);
            this.Controls.Add(this.lbIdKlijenta);
            this.Controls.Add(this.tbBrojRadnogNaloga);
            this.Controls.Add(this.lbBrRadnogNaloga);
            this.Controls.Add(this.btNoviRadniNalog);
            this.Controls.Add(this.btIzmjenaNaloga);
            this.Controls.Add(this.tcUslugaKomponenta);
            this.Controls.Add(this.tbKlijentGF);
            this.Controls.Add(this.lbKlijent);
            this.Controls.Add(this.btSacuvajIzmjene);
            this.Controls.Add(this.tcNalozi);
            this.Controls.Add(this.rbProknjizeni);
            this.Controls.Add(this.rbNeproknjizeni);
            this.Controls.Add(this.lbNapomena);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Controls.Add(this.lbDatumZavrsetka);
            this.Controls.Add(this.lbDatumKreiranja);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.tbZahtjev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKomponenta);
            this.Controls.Add(this.btnSubjekat);
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "GlavnaForma";
            this.Text = "SERVIS";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.tcNalozi.ResumeLayout(false);
            this.tabPageNeproknjizeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeproknjizeni)).EndInit();
            this.tabPageProknjizeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProknjizeni)).EndInit();
            this.tcUslugaKomponenta.ResumeLayout(false);
            this.tabPageUsluga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUslugaStavka)).EndInit();
            this.tabPageKomponenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomponentaStavka)).EndInit();
            this.gbPlacanje.ResumeLayout(false);
            this.gbPlacanje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubjekat;
        private System.Windows.Forms.Button btnKomponenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbZahtjev;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDatumKreiranja;
        private System.Windows.Forms.Label lbDatumZavrsetka;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.Label lbNapomena;
        private System.Windows.Forms.RadioButton rbNeproknjizeni;
        private System.Windows.Forms.RadioButton rbProknjizeni;
        private System.Windows.Forms.TabControl tcNalozi;
        private System.Windows.Forms.TabPage tabPageNeproknjizeni;
        private System.Windows.Forms.TabPage tabPageProknjizeni;
        private System.Windows.Forms.Button btSacuvajIzmjene;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbKlijent;
        private System.Windows.Forms.TabControl tcUslugaKomponenta;
        private System.Windows.Forms.TabPage tabPageUsluga;
        private System.Windows.Forms.TabPage tabPageKomponenta;
        private System.Windows.Forms.Button btIzmjenaNaloga;
        private System.Windows.Forms.Button btNoviRadniNalog;
        private System.Windows.Forms.Label lbBrRadnogNaloga;
        private System.Windows.Forms.TextBox tbBrojRadnogNaloga;
        private System.Windows.Forms.Label lbIdKlijenta;
        private System.Windows.Forms.Label lbZaprimio;
        private System.Windows.Forms.Label lbServiserRadi;
        private System.Windows.Forms.DataGridView dgvNeproknjizeni;
        private System.Windows.Forms.DataGridView dgvProknjizeni;
        private System.Windows.Forms.DataGridView dgvUslugaStavka;
        private System.Windows.Forms.DataGridView dgvKomponentaStavka;
        public System.Windows.Forms.TextBox tbKlijentGF;
        public System.Windows.Forms.TextBox tbIdKlijentaGF;
        private System.Windows.Forms.Button btDodajUslugu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPretraziNalog;
        private System.Windows.Forms.TextBox tbFilterNalog;
        private System.Windows.Forms.Button btOsvjeziUsluguKomponente;
        public System.Windows.Forms.ComboBox cbZaprimio;
        public System.Windows.Forms.ComboBox cbRadi;
        private System.Windows.Forms.Label lbUkupnoUsluge;
        private System.Windows.Forms.Label lbVrUsluge;
        private System.Windows.Forms.Label lbUkupnoKomponenti;
        private System.Windows.Forms.GroupBox gbPlacanje;
        private System.Windows.Forms.Label lbVrUkupno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbVrKomponente;
        public System.Windows.Forms.Button btSacuvajNalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSifraUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazivUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKolicinaUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRabat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUkupnaCijena;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnIzmjeniStavkuUsluge;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnObrisiStavkuUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSifraKomponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazivKomponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKolicinaKomponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCijenaKomponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRabatKomponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUkupnaCijenaKomponente;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnIzmjeniKS;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnObrisiKS;
        private System.Windows.Forms.Button btObrisiNalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrojNaloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDatumKreiranjaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImeKlijentaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPartnera;
        private System.Windows.Forms.Button btProknjizi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrojNalogaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDatumKreiranjaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPartneraProknjizeni;
        private System.Windows.Forms.Button button1;
    }
}

