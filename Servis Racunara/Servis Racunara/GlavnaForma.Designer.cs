
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbZahtjev = new System.Windows.Forms.Label();
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
            this.btDodajKomponentu = new System.Windows.Forms.Button();
            this.lbPretraziNalog = new System.Windows.Forms.Label();
            this.tbFilterNalog = new System.Windows.Forms.TextBox();
            this.lbUkupnoUsluge = new System.Windows.Forms.Label();
            this.lbVrUsluge = new System.Windows.Forms.Label();
            this.lbUkupnoKomponenti = new System.Windows.Forms.Label();
            this.gbPlacanje = new System.Windows.Forms.GroupBox();
            this.lbVrUkupno = new System.Windows.Forms.Label();
            this.lbUkupanIznosZaUplatu = new System.Windows.Forms.Label();
            this.lbVrKomponente = new System.Windows.Forms.Label();
            this.btObrisiNalog = new System.Windows.Forms.Button();
            this.btProknjizi = new System.Windows.Forms.Button();
            this.gbJezici = new System.Windows.Forms.GroupBox();
            this.rbPrevediNaSrpski = new System.Windows.Forms.RadioButton();
            this.rbPrevediNaengleski = new System.Windows.Forms.RadioButton();
            this.lbLogovaniSteKao = new System.Windows.Forms.Label();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.btPromjenaLozinke = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTeme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTemaBezTeme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontSegoeUI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontMagneto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontTahoma = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontConsolas = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btOsvjeziUsluguKomponente = new System.Windows.Forms.Button();
            this.btnKomponenta = new System.Windows.Forms.Button();
            this.btnSubjekat = new System.Windows.Forms.Button();
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
            this.gbJezici.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbZahtjev
            // 
            this.lbZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbZahtjev.AutoSize = true;
            this.lbZahtjev.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZahtjev.Location = new System.Drawing.Point(581, 135);
            this.lbZahtjev.Name = "lbZahtjev";
            this.lbZahtjev.Size = new System.Drawing.Size(89, 21);
            this.lbZahtjev.TabIndex = 15;
            this.lbZahtjev.Text = "ZAHTJEV:";
            this.lbZahtjev.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbZahtjev
            // 
            this.tbZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZahtjev.Location = new System.Drawing.Point(585, 159);
            this.tbZahtjev.Multiline = true;
            this.tbZahtjev.Name = "tbZahtjev";
            this.tbZahtjev.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbZahtjev.Size = new System.Drawing.Size(462, 99);
            this.tbZahtjev.TabIndex = 16;
            this.tbZahtjev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNapomena
            // 
            this.tbNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNapomena.Location = new System.Drawing.Point(591, 550);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNapomena.Size = new System.Drawing.Size(431, 152);
            this.tbNapomena.TabIndex = 21;
            this.tbNapomena.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(585, 281);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(204, 20);
            this.dtpDatumKreiranja.TabIndex = 18;
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
            this.cbStatus.Location = new System.Drawing.Point(585, 105);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(271, 25);
            this.cbStatus.TabIndex = 14;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(581, 82);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(80, 21);
            this.lbStatus.TabIndex = 13;
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
            this.lbDatumKreiranja.TabIndex = 17;
            this.lbDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lbDatumZavrsetka
            // 
            this.lbDatumZavrsetka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatumZavrsetka.AutoSize = true;
            this.lbDatumZavrsetka.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumZavrsetka.Location = new System.Drawing.Point(854, 261);
            this.lbDatumZavrsetka.Name = "lbDatumZavrsetka";
            this.lbDatumZavrsetka.Size = new System.Drawing.Size(110, 17);
            this.lbDatumZavrsetka.TabIndex = 26;
            this.lbDatumZavrsetka.Text = "Datum zavrsetka:";
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(857, 281);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(190, 20);
            this.dtpDatumZavrsetka.TabIndex = 27;
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
            this.lbNapomena.TabIndex = 20;
            this.lbNapomena.Text = "NAPOMENA:";
            // 
            // rbNeproknjizeni
            // 
            this.rbNeproknjizeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbNeproknjizeni.AutoSize = true;
            this.rbNeproknjizeni.Checked = true;
            this.rbNeproknjizeni.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNeproknjizeni.Location = new System.Drawing.Point(144, 445);
            this.rbNeproknjizeni.Name = "rbNeproknjizeni";
            this.rbNeproknjizeni.Size = new System.Drawing.Size(232, 25);
            this.rbNeproknjizeni.TabIndex = 8;
            this.rbNeproknjizeni.TabStop = true;
            this.rbNeproknjizeni.Text = "NEPROKNJIZENI NALOZI";
            this.rbNeproknjizeni.UseVisualStyleBackColor = true;
            this.rbNeproknjizeni.CheckedChanged += new System.EventHandler(this.rbNeproknjizeni_CheckedChanged);
            // 
            // rbProknjizeni
            // 
            this.rbProknjizeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbProknjizeni.AutoSize = true;
            this.rbProknjizeni.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProknjizeni.Location = new System.Drawing.Point(144, 486);
            this.rbProknjizeni.Name = "rbProknjizeni";
            this.rbProknjizeni.Size = new System.Drawing.Size(209, 25);
            this.rbProknjizeni.TabIndex = 9;
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
            this.tcNalozi.Size = new System.Drawing.Size(550, 306);
            this.tcNalozi.TabIndex = 6;
            this.tcNalozi.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcNalozi_Selected);
            // 
            // tabPageNeproknjizeni
            // 
            this.tabPageNeproknjizeni.Controls.Add(this.dgvNeproknjizeni);
            this.tabPageNeproknjizeni.Location = new System.Drawing.Point(4, 22);
            this.tabPageNeproknjizeni.Name = "tabPageNeproknjizeni";
            this.tabPageNeproknjizeni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNeproknjizeni.Size = new System.Drawing.Size(542, 280);
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
            this.dgvNeproknjizeni.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNeproknjizeni.Location = new System.Drawing.Point(0, 0);
            this.dgvNeproknjizeni.Name = "dgvNeproknjizeni";
            this.dgvNeproknjizeni.Size = new System.Drawing.Size(542, 280);
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
            this.tabPageProknjizeni.Size = new System.Drawing.Size(542, 280);
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
            this.dgvProknjizeni.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProknjizeni.Location = new System.Drawing.Point(0, 0);
            this.dgvProknjizeni.Name = "dgvProknjizeni";
            this.dgvProknjizeni.Size = new System.Drawing.Size(542, 282);
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
            this.btSacuvajIzmjene.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSacuvajIzmjene.Enabled = false;
            this.btSacuvajIzmjene.Location = new System.Drawing.Point(1061, 208);
            this.btSacuvajIzmjene.Name = "btSacuvajIzmjene";
            this.btSacuvajIzmjene.Size = new System.Drawing.Size(189, 45);
            this.btSacuvajIzmjene.TabIndex = 36;
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
            this.lbKlijent.Location = new System.Drawing.Point(581, 25);
            this.lbKlijent.Name = "lbKlijent";
            this.lbKlijent.Size = new System.Drawing.Size(82, 21);
            this.lbKlijent.TabIndex = 11;
            this.lbKlijent.Text = "KLIJENT:";
            // 
            // tbKlijentGF
            // 
            this.tbKlijentGF.AccessibleName = "tbKlijentGF";
            this.tbKlijentGF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKlijentGF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKlijentGF.Location = new System.Drawing.Point(585, 49);
            this.tbKlijentGF.Name = "tbKlijentGF";
            this.tbKlijentGF.ReadOnly = true;
            this.tbKlijentGF.Size = new System.Drawing.Size(271, 27);
            this.tbKlijentGF.TabIndex = 12;
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
            this.tcUslugaKomponenta.TabIndex = 19;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnIzmjeniStavkuUsluge.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnIzmjeniStavkuUsluge.HeaderText = "Izmjeni";
            this.ColumnIzmjeniStavkuUsluge.Name = "ColumnIzmjeniStavkuUsluge";
            this.ColumnIzmjeniStavkuUsluge.ReadOnly = true;
            this.ColumnIzmjeniStavkuUsluge.Text = "Izmjeni";
            this.ColumnIzmjeniStavkuUsluge.UseColumnTextForButtonValue = true;
            // 
            // ColumnObrisiStavkuUsluge
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnObrisiStavkuUsluge.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnIzmjeniKS.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnIzmjeniKS.HeaderText = "Izmjeni";
            this.ColumnIzmjeniKS.Name = "ColumnIzmjeniKS";
            this.ColumnIzmjeniKS.Text = "Izmjeni";
            this.ColumnIzmjeniKS.UseColumnTextForButtonValue = true;
            // 
            // ColumnObrisiKS
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnObrisiKS.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnObrisiKS.HeaderText = "Obrisi";
            this.ColumnObrisiKS.Name = "ColumnObrisiKS";
            this.ColumnObrisiKS.Text = "Obrisi";
            this.ColumnObrisiKS.UseColumnTextForButtonValue = true;
            // 
            // btIzmjenaNaloga
            // 
            this.btIzmjenaNaloga.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btIzmjenaNaloga.Location = new System.Drawing.Point(1061, 149);
            this.btIzmjenaNaloga.Name = "btIzmjenaNaloga";
            this.btIzmjenaNaloga.Size = new System.Drawing.Size(189, 45);
            this.btIzmjenaNaloga.TabIndex = 35;
            this.btIzmjenaNaloga.Text = "IZMJENA NALOGA";
            this.btIzmjenaNaloga.UseVisualStyleBackColor = true;
            this.btIzmjenaNaloga.Click += new System.EventHandler(this.btIzmjenaNaloga_Click);
            // 
            // btNoviRadniNalog
            // 
            this.btNoviRadniNalog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btNoviRadniNalog.Location = new System.Drawing.Point(1061, 31);
            this.btNoviRadniNalog.Name = "btNoviRadniNalog";
            this.btNoviRadniNalog.Size = new System.Drawing.Size(189, 45);
            this.btNoviRadniNalog.TabIndex = 33;
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
            this.lbBrRadnogNaloga.Location = new System.Drawing.Point(889, 82);
            this.lbBrRadnogNaloga.Name = "lbBrRadnogNaloga";
            this.lbBrRadnogNaloga.Size = new System.Drawing.Size(85, 20);
            this.lbBrRadnogNaloga.TabIndex = 24;
            this.lbBrRadnogNaloga.Text = "Br.Naloga:";
            // 
            // tbBrojRadnogNaloga
            // 
            this.tbBrojRadnogNaloga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrojRadnogNaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojRadnogNaloga.Location = new System.Drawing.Point(894, 105);
            this.tbBrojRadnogNaloga.Name = "tbBrojRadnogNaloga";
            this.tbBrojRadnogNaloga.ReadOnly = true;
            this.tbBrojRadnogNaloga.Size = new System.Drawing.Size(97, 26);
            this.tbBrojRadnogNaloga.TabIndex = 25;
            // 
            // lbIdKlijenta
            // 
            this.lbIdKlijenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIdKlijenta.AutoSize = true;
            this.lbIdKlijenta.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdKlijenta.Location = new System.Drawing.Point(890, 26);
            this.lbIdKlijenta.Name = "lbIdKlijenta";
            this.lbIdKlijenta.Size = new System.Drawing.Size(86, 20);
            this.lbIdKlijenta.TabIndex = 22;
            this.lbIdKlijenta.Text = "IDKlijenta:";
            this.lbIdKlijenta.Click += new System.EventHandler(this.lbBroj_Click);
            // 
            // tbIdKlijentaGF
            // 
            this.tbIdKlijentaGF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdKlijentaGF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdKlijentaGF.Location = new System.Drawing.Point(893, 49);
            this.tbIdKlijentaGF.Name = "tbIdKlijentaGF";
            this.tbIdKlijentaGF.ReadOnly = true;
            this.tbIdKlijentaGF.Size = new System.Drawing.Size(97, 27);
            this.tbIdKlijentaGF.TabIndex = 23;
            this.tbIdKlijentaGF.TextChanged += new System.EventHandler(this.tbIdKlijentaGF_TextChanged);
            // 
            // lbZaprimio
            // 
            this.lbZaprimio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbZaprimio.AutoSize = true;
            this.lbZaprimio.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZaprimio.Location = new System.Drawing.Point(1057, 607);
            this.lbZaprimio.Name = "lbZaprimio";
            this.lbZaprimio.Size = new System.Drawing.Size(100, 21);
            this.lbZaprimio.TabIndex = 29;
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
            this.cbZaprimio.TabIndex = 30;
            // 
            // cbRadi
            // 
            this.cbRadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRadi.FormattingEnabled = true;
            this.cbRadi.Location = new System.Drawing.Point(1061, 681);
            this.cbRadi.Name = "cbRadi";
            this.cbRadi.Size = new System.Drawing.Size(218, 21);
            this.cbRadi.TabIndex = 32;
            // 
            // btSacuvajNalog
            // 
            this.btSacuvajNalog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSacuvajNalog.Enabled = false;
            this.btSacuvajNalog.Location = new System.Drawing.Point(1061, 90);
            this.btSacuvajNalog.Name = "btSacuvajNalog";
            this.btSacuvajNalog.Size = new System.Drawing.Size(189, 45);
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
            this.btDodajUslugu.TabIndex = 38;
            this.btDodajUslugu.Text = "DODAJ USLUGU";
            this.btDodajUslugu.UseVisualStyleBackColor = true;
            this.btDodajUslugu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btDodajKomponentu
            // 
            this.btDodajKomponentu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDodajKomponentu.Location = new System.Drawing.Point(1232, 396);
            this.btDodajKomponentu.Name = "btDodajKomponentu";
            this.btDodajKomponentu.Size = new System.Drawing.Size(105, 41);
            this.btDodajKomponentu.TabIndex = 39;
            this.btDodajKomponentu.Text = "DODAJ KOMPONENTU";
            this.btDodajKomponentu.UseVisualStyleBackColor = true;
            this.btDodajKomponentu.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPretraziNalog
            // 
            this.lbPretraziNalog.AutoSize = true;
            this.lbPretraziNalog.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPretraziNalog.Location = new System.Drawing.Point(222, 113);
            this.lbPretraziNalog.Name = "lbPretraziNalog";
            this.lbPretraziNalog.Size = new System.Drawing.Size(70, 21);
            this.lbPretraziNalog.TabIndex = 3;
            this.lbPretraziNalog.Text = "Pretrazi:";
            // 
            // tbFilterNalog
            // 
            this.tbFilterNalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterNalog.Location = new System.Drawing.Point(334, 113);
            this.tbFilterNalog.Name = "tbFilterNalog";
            this.tbFilterNalog.Size = new System.Drawing.Size(220, 20);
            this.tbFilterNalog.TabIndex = 4;
            this.tbFilterNalog.TextChanged += new System.EventHandler(this.tbFilterNalog_TextChanged);
            // 
            // lbUkupnoUsluge
            // 
            this.lbUkupnoUsluge.AutoSize = true;
            this.lbUkupnoUsluge.Location = new System.Drawing.Point(6, 25);
            this.lbUkupnoUsluge.Name = "lbUkupnoUsluge";
            this.lbUkupnoUsluge.Size = new System.Drawing.Size(89, 13);
            this.lbUkupnoUsluge.TabIndex = 0;
            this.lbUkupnoUsluge.Text = "Usluge za uplatu:";
            // 
            // lbVrUsluge
            // 
            this.lbVrUsluge.AutoSize = true;
            this.lbVrUsluge.Location = new System.Drawing.Point(202, 25);
            this.lbVrUsluge.Name = "lbVrUsluge";
            this.lbVrUsluge.Size = new System.Drawing.Size(28, 13);
            this.lbVrUsluge.TabIndex = 3;
            this.lbVrUsluge.Text = "0.00";
            this.lbVrUsluge.Click += new System.EventHandler(this.lbVrUsluge_Click);
            // 
            // lbUkupnoKomponenti
            // 
            this.lbUkupnoKomponenti.AutoSize = true;
            this.lbUkupnoKomponenti.Location = new System.Drawing.Point(6, 47);
            this.lbUkupnoKomponenti.Name = "lbUkupnoKomponenti";
            this.lbUkupnoKomponenti.Size = new System.Drawing.Size(94, 13);
            this.lbUkupnoKomponenti.TabIndex = 1;
            this.lbUkupnoKomponenti.Text = "Dijelova za uplatu:";
            // 
            // gbPlacanje
            // 
            this.gbPlacanje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlacanje.Controls.Add(this.lbVrUkupno);
            this.gbPlacanje.Controls.Add(this.lbUkupanIznosZaUplatu);
            this.gbPlacanje.Controls.Add(this.lbVrKomponente);
            this.gbPlacanje.Controls.Add(this.lbVrUsluge);
            this.gbPlacanje.Controls.Add(this.lbUkupnoKomponenti);
            this.gbPlacanje.Controls.Add(this.lbUkupnoUsluge);
            this.gbPlacanje.Location = new System.Drawing.Point(1061, 517);
            this.gbPlacanje.Name = "gbPlacanje";
            this.gbPlacanje.Size = new System.Drawing.Size(260, 87);
            this.gbPlacanje.TabIndex = 28;
            this.gbPlacanje.TabStop = false;
            this.gbPlacanje.Text = "IZNOS ZA PLACANJE:";
            // 
            // lbVrUkupno
            // 
            this.lbVrUkupno.AutoSize = true;
            this.lbVrUkupno.Location = new System.Drawing.Point(202, 69);
            this.lbVrUkupno.Name = "lbVrUkupno";
            this.lbVrUkupno.Size = new System.Drawing.Size(28, 13);
            this.lbVrUkupno.TabIndex = 5;
            this.lbVrUkupno.Text = "0.00";
            // 
            // lbUkupanIznosZaUplatu
            // 
            this.lbUkupanIznosZaUplatu.AutoSize = true;
            this.lbUkupanIznosZaUplatu.Location = new System.Drawing.Point(6, 69);
            this.lbUkupanIznosZaUplatu.Name = "lbUkupanIznosZaUplatu";
            this.lbUkupanIznosZaUplatu.Size = new System.Drawing.Size(147, 13);
            this.lbUkupanIznosZaUplatu.TabIndex = 2;
            this.lbUkupanIznosZaUplatu.Text = "UKUPNI IZNOS ZA UPLATU";
            // 
            // lbVrKomponente
            // 
            this.lbVrKomponente.AutoSize = true;
            this.lbVrKomponente.Location = new System.Drawing.Point(202, 47);
            this.lbVrKomponente.Name = "lbVrKomponente";
            this.lbVrKomponente.Size = new System.Drawing.Size(28, 13);
            this.lbVrKomponente.TabIndex = 4;
            this.lbVrKomponente.Text = "0.00";
            // 
            // btObrisiNalog
            // 
            this.btObrisiNalog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btObrisiNalog.Location = new System.Drawing.Point(1061, 267);
            this.btObrisiNalog.Name = "btObrisiNalog";
            this.btObrisiNalog.Size = new System.Drawing.Size(189, 45);
            this.btObrisiNalog.TabIndex = 37;
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
            this.btProknjizi.TabIndex = 10;
            this.btProknjizi.Text = "PROKNJIZI NALOG";
            this.btProknjizi.UseVisualStyleBackColor = true;
            this.btProknjizi.Click += new System.EventHandler(this.btProknjizi_Click);
            // 
            // gbJezici
            // 
            this.gbJezici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbJezici.Controls.Add(this.rbPrevediNaSrpski);
            this.gbJezici.Controls.Add(this.rbPrevediNaengleski);
            this.gbJezici.Location = new System.Drawing.Point(1256, 27);
            this.gbJezici.Name = "gbJezici";
            this.gbJezici.Size = new System.Drawing.Size(83, 118);
            this.gbJezici.TabIndex = 42;
            this.gbJezici.TabStop = false;
            // 
            // rbPrevediNaSrpski
            // 
            this.rbPrevediNaSrpski.AutoSize = true;
            this.rbPrevediNaSrpski.Image = global::Servis_Racunara.Properties.Resources.hiclipart_com__3_;
            this.rbPrevediNaSrpski.Location = new System.Drawing.Point(12, 13);
            this.rbPrevediNaSrpski.Name = "rbPrevediNaSrpski";
            this.rbPrevediNaSrpski.Size = new System.Drawing.Size(59, 45);
            this.rbPrevediNaSrpski.TabIndex = 1;
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
            this.rbPrevediNaengleski.TabIndex = 1;
            this.rbPrevediNaengleski.TabStop = true;
            this.rbPrevediNaengleski.UseVisualStyleBackColor = true;
            this.rbPrevediNaengleski.CheckedChanged += new System.EventHandler(this.rbPrevediNaengleski_CheckedChanged);
            // 
            // lbLogovaniSteKao
            // 
            this.lbLogovaniSteKao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLogovaniSteKao.AutoSize = true;
            this.lbLogovaniSteKao.Location = new System.Drawing.Point(12, 699);
            this.lbLogovaniSteKao.Name = "lbLogovaniSteKao";
            this.lbLogovaniSteKao.Size = new System.Drawing.Size(54, 13);
            this.lbLogovaniSteKao.TabIndex = 43;
            this.lbLogovaniSteKao.Text = "Korosnik :";
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(75, 699);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(35, 13);
            this.lbKorisnickoIme.TabIndex = 0;
            this.lbKorisnickoIme.Text = "admin";
            // 
            // btPromjenaLozinke
            // 
            this.btPromjenaLozinke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPromjenaLozinke.Location = new System.Drawing.Point(333, 694);
            this.btPromjenaLozinke.Name = "btPromjenaLozinke";
            this.btPromjenaLozinke.Size = new System.Drawing.Size(221, 23);
            this.btPromjenaLozinke.TabIndex = 1;
            this.btPromjenaLozinke.Text = "Promjena lozinke";
            this.btPromjenaLozinke.UseVisualStyleBackColor = true;
            this.btPromjenaLozinke.Click += new System.EventHandler(this.btPromjenaLozinke_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTeme,
            this.tsmFont});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1344, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTeme
            // 
            this.tsmTeme.CheckOnClick = true;
            this.tsmTeme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTema1,
            this.tsmiTema2,
            this.tsmiTema3,
            this.tsmiTemaBezTeme});
            this.tsmTeme.Name = "tsmTeme";
            this.tsmTeme.Size = new System.Drawing.Size(47, 19);
            this.tsmTeme.Text = "Teme";
            this.tsmTeme.Click += new System.EventHandler(this.temeToolStripMenuItem_Click);
            // 
            // tsmiTema1
            // 
            this.tsmiTema1.CheckOnClick = true;
            this.tsmiTema1.Name = "tsmiTema1";
            this.tsmiTema1.Size = new System.Drawing.Size(122, 22);
            this.tsmiTema1.Text = "Tema 1";
            this.tsmiTema1.Click += new System.EventHandler(this.tema1ToolStripMenuItem_Click);
            // 
            // tsmiTema2
            // 
            this.tsmiTema2.BackColor = System.Drawing.Color.LimeGreen;
            this.tsmiTema2.CheckOnClick = true;
            this.tsmiTema2.Name = "tsmiTema2";
            this.tsmiTema2.Size = new System.Drawing.Size(122, 22);
            this.tsmiTema2.Text = "Tema 2";
            this.tsmiTema2.Click += new System.EventHandler(this.tema2ToolStripMenuItem_Click);
            // 
            // tsmiTema3
            // 
            this.tsmiTema3.CheckOnClick = true;
            this.tsmiTema3.Name = "tsmiTema3";
            this.tsmiTema3.Size = new System.Drawing.Size(122, 22);
            this.tsmiTema3.Text = "Tema 3";
            this.tsmiTema3.Click += new System.EventHandler(this.tema3ToolStripMenuItem_Click);
            // 
            // tsmiTemaBezTeme
            // 
            this.tsmiTemaBezTeme.Name = "tsmiTemaBezTeme";
            this.tsmiTemaBezTeme.Size = new System.Drawing.Size(122, 22);
            this.tsmiTemaBezTeme.Text = "Bez teme";
            this.tsmiTemaBezTeme.Click += new System.EventHandler(this.bezTemeToolStripMenuItem_Click);
            // 
            // tsmFont
            // 
            this.tsmFont.Checked = true;
            this.tsmFont.CheckOnClick = true;
            this.tsmFont.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFontSegoeUI,
            this.tsmiFontMagneto,
            this.tsmiFontTahoma,
            this.tsmiFontConsolas});
            this.tsmFont.Name = "tsmFont";
            this.tsmFont.Size = new System.Drawing.Size(59, 19);
            this.tsmFont.Text = "Fontovi";
            // 
            // tsmiFontSegoeUI
            // 
            this.tsmiFontSegoeUI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFontSegoeUI.Name = "tsmiFontSegoeUI";
            this.tsmiFontSegoeUI.Size = new System.Drawing.Size(132, 22);
            this.tsmiFontSegoeUI.Text = "Segoe UI";
            this.tsmiFontSegoeUI.Click += new System.EventHandler(this.bookAntiquaToolStripMenuItem_Click);
            // 
            // tsmiFontMagneto
            // 
            this.tsmiFontMagneto.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFontMagneto.Name = "tsmiFontMagneto";
            this.tsmiFontMagneto.Size = new System.Drawing.Size(132, 22);
            this.tsmiFontMagneto.Text = "Magneto";
            this.tsmiFontMagneto.Click += new System.EventHandler(this.magnetoToolStripMenuItem_Click);
            // 
            // tsmiFontTahoma
            // 
            this.tsmiFontTahoma.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFontTahoma.Name = "tsmiFontTahoma";
            this.tsmiFontTahoma.Size = new System.Drawing.Size(132, 22);
            this.tsmiFontTahoma.Text = "Tahoma";
            this.tsmiFontTahoma.Click += new System.EventHandler(this.tahomaToolStripMenuItem_Click);
            // 
            // tsmiFontConsolas
            // 
            this.tsmiFontConsolas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFontConsolas.Name = "tsmiFontConsolas";
            this.tsmiFontConsolas.Size = new System.Drawing.Size(132, 22);
            this.tsmiFontConsolas.Text = "Consolas";
            this.tsmiFontConsolas.Click += new System.EventHandler(this.consolasToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = global::Servis_Racunara.Properties.Resources.refresh__1_;
            this.button1.Location = new System.Drawing.Point(8, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
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
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.btPromjenaLozinke);
            this.Controls.Add(this.lbKorisnickoIme);
            this.Controls.Add(this.lbLogovaniSteKao);
            this.Controls.Add(this.gbJezici);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btProknjizi);
            this.Controls.Add(this.btObrisiNalog);
            this.Controls.Add(this.gbPlacanje);
            this.Controls.Add(this.btOsvjeziUsluguKomponente);
            this.Controls.Add(this.tbFilterNalog);
            this.Controls.Add(this.lbPretraziNalog);
            this.Controls.Add(this.btDodajKomponentu);
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
            this.Controls.Add(this.lbZahtjev);
            this.Controls.Add(this.btnKomponenta);
            this.Controls.Add(this.btnSubjekat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.gbJezici.ResumeLayout(false);
            this.gbJezici.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubjekat;
        private System.Windows.Forms.Button btnKomponenta;
        private System.Windows.Forms.Label lbZahtjev;
        private System.Windows.Forms.Label lbDatumKreiranja;
        private System.Windows.Forms.Label lbDatumZavrsetka;
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
        private System.Windows.Forms.Label lbIdKlijenta;
        private System.Windows.Forms.Label lbZaprimio;
        private System.Windows.Forms.Label lbServiserRadi;
        private System.Windows.Forms.DataGridView dgvNeproknjizeni;
        private System.Windows.Forms.DataGridView dgvProknjizeni;
        public System.Windows.Forms.TextBox tbKlijentGF;
        public System.Windows.Forms.TextBox tbIdKlijentaGF;
        private System.Windows.Forms.Button btDodajUslugu;
        private System.Windows.Forms.Button btDodajKomponentu;
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
        private System.Windows.Forms.Label lbUkupanIznosZaUplatu;
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
        public System.Windows.Forms.RadioButton rbPrevediNaSrpski;
        public System.Windows.Forms.RadioButton rbPrevediNaengleski;
        private System.Windows.Forms.GroupBox gbJezici;
        public System.Windows.Forms.Label lbLogovaniSteKao;
        public System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Button btPromjenaLozinke;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem tsmTeme;
        public System.Windows.Forms.ToolStripMenuItem tsmiTema1;
        public System.Windows.Forms.ToolStripMenuItem tsmiTema2;
        public System.Windows.Forms.ToolStripMenuItem tsmiTema3;
        public System.Windows.Forms.ToolStripMenuItem tsmFont;
        public System.Windows.Forms.ToolStripMenuItem tsmiFontSegoeUI;
        public System.Windows.Forms.ToolStripMenuItem tsmiFontMagneto;
        public System.Windows.Forms.ToolStripMenuItem tsmiFontTahoma;
        public System.Windows.Forms.ToolStripMenuItem tsmiFontConsolas;
        public System.Windows.Forms.ToolStripMenuItem tsmiTemaBezTeme;
        public System.Windows.Forms.TextBox tbZahtjev;
        public System.Windows.Forms.TextBox tbNapomena;
        public System.Windows.Forms.TextBox tbBrojRadnogNaloga;
        public System.Windows.Forms.DataGridView dgvUslugaStavka;
        public System.Windows.Forms.DataGridView dgvKomponentaStavka;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.Label lbStatus;
        public System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        public System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
    }
}

