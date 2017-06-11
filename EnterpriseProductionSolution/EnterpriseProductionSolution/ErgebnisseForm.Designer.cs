namespace EnterprisePlanningSolution
{
    partial class ErgebnisseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Lagerbestand = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Artikelnummer_Bestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startmenge_Bestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge_Bestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prozentmenge_Bestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis_Bestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagerwert_Bestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodeLager = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Bestellungen = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.PeriodeBest = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.Lagerzugang = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.PeriodeZugangCombo = new MetroFramework.Controls.MetroComboBox();
            this.PeriodeZugang = new MetroFramework.Controls.MetroLabel();
            this.Kennzahlen = new System.Windows.Forms.TabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid4 = new MetroFramework.Controls.MetroGrid();
            this.PeriodeKennCombo = new MetroFramework.Controls.MetroComboBox();
            this.PeriodeKenn = new MetroFramework.Controls.MetroLabel();
            this.Gewinn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GewinnDurchschnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GewinnGesamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelnummer_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelnummer_Bestellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge_Bestellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KostenGesamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kosten_Bestellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.Lagerbestand.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.Bestellungen.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.Lagerzugang.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            this.Kennzahlen.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Lagerbestand);
            this.metroTabControl1.Controls.Add(this.Bestellungen);
            this.metroTabControl1.Controls.Add(this.Lagerzugang);
            this.metroTabControl1.Controls.Add(this.Kennzahlen);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(853, 429);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Lagerbestand
            // 
            this.Lagerbestand.Controls.Add(this.metroPanel1);
            this.Lagerbestand.Location = new System.Drawing.Point(4, 38);
            this.Lagerbestand.Name = "Lagerbestand";
            this.Lagerbestand.Size = new System.Drawing.Size(845, 387);
            this.Lagerbestand.TabIndex = 0;
            this.Lagerbestand.Text = "Lagerbestand";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.Controls.Add(this.PeriodeLager);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 17);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1026, 522);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer_Bestand,
            this.Startmenge_Bestand,
            this.Menge_Bestand,
            this.Prozentmenge_Bestand,
            this.Preis_Bestand,
            this.Lagerwert_Bestand});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(30, 74);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(657, 206);
            this.metroGrid1.TabIndex = 6;
            // 
            // Artikelnummer_Bestand
            // 
            this.Artikelnummer_Bestand.HeaderText = "Artikelnummer";
            this.Artikelnummer_Bestand.Name = "Artikelnummer_Bestand";
            // 
            // Startmenge_Bestand
            // 
            this.Startmenge_Bestand.HeaderText = "Startmenge";
            this.Startmenge_Bestand.Name = "Startmenge_Bestand";
            // 
            // Menge_Bestand
            // 
            this.Menge_Bestand.HeaderText = "Menge";
            this.Menge_Bestand.Name = "Menge_Bestand";
            // 
            // Prozentmenge_Bestand
            // 
            this.Prozentmenge_Bestand.HeaderText = "Prozentmenge";
            this.Prozentmenge_Bestand.Name = "Prozentmenge_Bestand";
            // 
            // Preis_Bestand
            // 
            this.Preis_Bestand.HeaderText = "Preis Pro Stück";
            this.Preis_Bestand.Name = "Preis_Bestand";
            // 
            // Lagerwert_Bestand
            // 
            this.Lagerwert_Bestand.HeaderText = "Lagerwert";
            this.Lagerwert_Bestand.Name = "Lagerwert_Bestand";
            // 
            // PeriodeLager
            // 
            this.PeriodeLager.Location = new System.Drawing.Point(30, 26);
            this.PeriodeLager.Name = "PeriodeLager";
            this.PeriodeLager.Size = new System.Drawing.Size(85, 29);
            this.PeriodeLager.TabIndex = 5;
            this.PeriodeLager.Text = "Periode";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(121, 26);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Bestellungen
            // 
            this.Bestellungen.Controls.Add(this.metroPanel2);
            this.Bestellungen.Location = new System.Drawing.Point(4, 38);
            this.Bestellungen.Name = "Bestellungen";
            this.Bestellungen.Size = new System.Drawing.Size(845, 387);
            this.Bestellungen.TabIndex = 1;
            this.Bestellungen.Text = "Bestellungen";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroGrid2);
            this.metroPanel2.Controls.Add(this.PeriodeBest);
            this.metroPanel2.Controls.Add(this.metroComboBox2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 17);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1026, 522);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer_Bestellung,
            this.Menge_Bestellung,
            this.KostenGesamt,
            this.Kosten_Bestellung});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(30, 72);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(500, 206);
            this.metroGrid2.TabIndex = 9;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick);
            // 
            // PeriodeBest
            // 
            this.PeriodeBest.Location = new System.Drawing.Point(30, 26);
            this.PeriodeBest.Name = "PeriodeBest";
            this.PeriodeBest.Size = new System.Drawing.Size(85, 29);
            this.PeriodeBest.TabIndex = 8;
            this.PeriodeBest.Text = "Periode";
            this.PeriodeBest.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(121, 24);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 7;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Lagerzugang
            // 
            this.Lagerzugang.Controls.Add(this.metroPanel3);
            this.Lagerzugang.Location = new System.Drawing.Point(4, 38);
            this.Lagerzugang.Name = "Lagerzugang";
            this.Lagerzugang.Size = new System.Drawing.Size(845, 387);
            this.Lagerzugang.TabIndex = 2;
            this.Lagerzugang.Text = "Lagerzugang";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroGrid3);
            this.metroPanel3.Controls.Add(this.PeriodeZugangCombo);
            this.metroPanel3.Controls.Add(this.PeriodeZugang);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(23, 17);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1026, 522);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer_Zugang,
            this.Menge_Zugang,
            this.Preis_Zugang});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(30, 74);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(433, 206);
            this.metroGrid3.TabIndex = 4;
            // 
            // PeriodeZugangCombo
            // 
            this.PeriodeZugangCombo.FormattingEnabled = true;
            this.PeriodeZugangCombo.ItemHeight = 23;
            this.PeriodeZugangCombo.Location = new System.Drawing.Point(121, 26);
            this.PeriodeZugangCombo.Name = "PeriodeZugangCombo";
            this.PeriodeZugangCombo.Size = new System.Drawing.Size(121, 29);
            this.PeriodeZugangCombo.TabIndex = 3;
            this.PeriodeZugangCombo.UseSelectable = true;
            // 
            // PeriodeZugang
            // 
            this.PeriodeZugang.AutoSize = true;
            this.PeriodeZugang.Location = new System.Drawing.Point(30, 26);
            this.PeriodeZugang.Name = "PeriodeZugang";
            this.PeriodeZugang.Size = new System.Drawing.Size(54, 19);
            this.PeriodeZugang.TabIndex = 2;
            this.PeriodeZugang.Text = "Periode";
            // 
            // Kennzahlen
            // 
            this.Kennzahlen.Controls.Add(this.metroPanel4);
            this.Kennzahlen.Location = new System.Drawing.Point(4, 38);
            this.Kennzahlen.Name = "Kennzahlen";
            this.Kennzahlen.Size = new System.Drawing.Size(845, 387);
            this.Kennzahlen.TabIndex = 3;
            this.Kennzahlen.Text = "Kennzahlen";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroGrid4);
            this.metroPanel4.Controls.Add(this.PeriodeKennCombo);
            this.metroPanel4.Controls.Add(this.PeriodeKenn);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(23, 17);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1026, 522);
            this.metroPanel4.TabIndex = 0;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroGrid4
            // 
            this.metroGrid4.AllowUserToResizeRows = false;
            this.metroGrid4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gewinn,
            this.GewinnDurchschnitt,
            this.GewinnGesamt});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid4.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid4.EnableHeadersVisualStyles = false;
            this.metroGrid4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.Location = new System.Drawing.Point(30, 74);
            this.metroGrid4.Name = "metroGrid4";
            this.metroGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid4.Size = new System.Drawing.Size(433, 206);
            this.metroGrid4.TabIndex = 4;
            // 
            // PeriodeKennCombo
            // 
            this.PeriodeKennCombo.FormattingEnabled = true;
            this.PeriodeKennCombo.ItemHeight = 23;
            this.PeriodeKennCombo.Location = new System.Drawing.Point(121, 29);
            this.PeriodeKennCombo.Name = "PeriodeKennCombo";
            this.PeriodeKennCombo.Size = new System.Drawing.Size(121, 29);
            this.PeriodeKennCombo.TabIndex = 3;
            this.PeriodeKennCombo.UseSelectable = true;
            // 
            // PeriodeKenn
            // 
            this.PeriodeKenn.AutoSize = true;
            this.PeriodeKenn.Location = new System.Drawing.Point(30, 26);
            this.PeriodeKenn.Name = "PeriodeKenn";
            this.PeriodeKenn.Size = new System.Drawing.Size(54, 19);
            this.PeriodeKenn.TabIndex = 2;
            this.PeriodeKenn.Text = "Periode";
            // 
            // Gewinn
            // 
            this.Gewinn.HeaderText = "Gewinn Aktuell";
            this.Gewinn.Name = "Gewinn";
            // 
            // GewinnDurchschnitt
            // 
            this.GewinnDurchschnitt.HeaderText = "Durchschnittlicher Gewinn";
            this.GewinnDurchschnitt.Name = "GewinnDurchschnitt";
            // 
            // GewinnGesamt
            // 
            this.GewinnGesamt.HeaderText = "Gesamter Gewinn";
            this.GewinnGesamt.Name = "GewinnGesamt";
            // 
            // Artikelnummer_Zugang
            // 
            this.Artikelnummer_Zugang.HeaderText = "Artikelnummer";
            this.Artikelnummer_Zugang.Name = "Artikelnummer_Zugang";
            // 
            // Menge_Zugang
            // 
            this.Menge_Zugang.HeaderText = "Menge";
            this.Menge_Zugang.Name = "Menge_Zugang";
            // 
            // Preis_Zugang
            // 
            this.Preis_Zugang.HeaderText = "Preis Pro Stück";
            this.Preis_Zugang.Name = "Preis_Zugang";
            // 
            // Artikelnummer_Bestellung
            // 
            this.Artikelnummer_Bestellung.HeaderText = "Artikelnummer";
            this.Artikelnummer_Bestellung.Name = "Artikelnummer_Bestellung";
            // 
            // Menge_Bestellung
            // 
            this.Menge_Bestellung.HeaderText = "Menge";
            this.Menge_Bestellung.Name = "Menge_Bestellung";
            // 
            // KostenGesamt
            // 
            this.KostenGesamt.HeaderText = "Gesamt Kosten";
            this.KostenGesamt.Name = "KostenGesamt";
            // 
            // Kosten_Bestellung
            // 
            this.Kosten_Bestellung.HeaderText = "Kosten pro Stück";
            this.Kosten_Bestellung.Name = "Kosten_Bestellung";
            // 
            // ErgebnisseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 516);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "ErgebnisseForm";
            this.Text = "ErgebnisseForm";
            this.Load += new System.EventHandler(this.ErgebnisseForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Lagerbestand.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.Bestellungen.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.Lagerzugang.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            this.Kennzahlen.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Lagerbestand;
        private System.Windows.Forms.TabPage Bestellungen;
        private System.Windows.Forms.TabPage Lagerzugang;
        private System.Windows.Forms.TabPage Kennzahlen;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel PeriodeLager;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroLabel PeriodeBest;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroComboBox PeriodeZugangCombo;
        private MetroFramework.Controls.MetroLabel PeriodeZugang;
        private MetroFramework.Controls.MetroGrid metroGrid4;
        private MetroFramework.Controls.MetroComboBox PeriodeKennCombo;
        private MetroFramework.Controls.MetroLabel PeriodeKenn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer_Bestand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startmenge_Bestand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge_Bestand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prozentmenge_Bestand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis_Bestand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagerwert_Bestand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer_Bestellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge_Bestellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn KostenGesamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kosten_Bestellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gewinn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GewinnDurchschnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GewinnGesamt;
    }
}