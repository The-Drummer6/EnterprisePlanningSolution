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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErgebnisseForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Lagerbestand = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lagerTortendiagramm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PeriodeLager = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Bestellungen = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.Artikelnummer_Bestellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge_Bestellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bestellart_Bestellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodeBest = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.Lagerzugang = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.Artikelnummer_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bestellperiode_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modus_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieferzeit_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis_Zugang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.PeriodeZugang = new MetroFramework.Controls.MetroLabel();
            this.Kennzahlen = new System.Windows.Forms.TabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid4 = new MetroFramework.Controls.MetroGrid();
            this.Gewinn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GewinnDurchschnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GewinnGesamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagerwert_Kenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagerkosten_Kenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnzahlLager_Kenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.PeriodeKenn = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.Lagerbestand.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lagerTortendiagramm)).BeginInit();
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
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(1097, 627);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Lagerbestand
            // 
            this.Lagerbestand.AutoScroll = true;
            this.Lagerbestand.Controls.Add(this.metroPanel1);
            this.Lagerbestand.Location = new System.Drawing.Point(4, 38);
            this.Lagerbestand.Name = "Lagerbestand";
            this.Lagerbestand.Size = new System.Drawing.Size(1089, 585);
            this.Lagerbestand.TabIndex = 0;
            this.Lagerbestand.Text = "Lagerbestand";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lagerTortendiagramm);
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
            // lagerTortendiagramm
            // 
            chartArea5.Name = "ChartArea1";
            chartArea6.Name = "ChartArea2";
            this.lagerTortendiagramm.ChartAreas.Add(chartArea5);
            this.lagerTortendiagramm.ChartAreas.Add(chartArea6);
            legend3.Name = "Legend1";
            this.lagerTortendiagramm.Legends.Add(legend3);
            this.lagerTortendiagramm.Location = new System.Drawing.Point(248, 26);
            this.lagerTortendiagramm.Name = "lagerTortendiagramm";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.lagerTortendiagramm.Series.Add(series3);
            this.lagerTortendiagramm.Size = new System.Drawing.Size(300, 300);
            this.lagerTortendiagramm.TabIndex = 6;
            this.lagerTortendiagramm.Text = "Befüllung Lager";
            this.lagerTortendiagramm.Click += new System.EventHandler(this.lagerTortendiagramm_Click);
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
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Bestellungen
            // 
            this.Bestellungen.Controls.Add(this.metroPanel2);
            this.Bestellungen.Location = new System.Drawing.Point(4, 38);
            this.Bestellungen.Name = "Bestellungen";
            this.Bestellungen.Size = new System.Drawing.Size(1089, 585);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer_Bestellung,
            this.Menge_Bestellung,
            this.Bestellart_Bestellung});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle23;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(30, 72);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(500, 206);
            this.metroGrid2.TabIndex = 9;
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
            // Bestellart_Bestellung
            // 
            this.Bestellart_Bestellung.HeaderText = "Bestellart";
            this.Bestellart_Bestellung.Name = "Bestellart_Bestellung";
            // 
            // PeriodeBest
            // 
            this.PeriodeBest.Location = new System.Drawing.Point(30, 26);
            this.PeriodeBest.Name = "PeriodeBest";
            this.PeriodeBest.Size = new System.Drawing.Size(85, 29);
            this.PeriodeBest.TabIndex = 8;
            this.PeriodeBest.Text = "Periode";
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
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // Lagerzugang
            // 
            this.Lagerzugang.Controls.Add(this.metroPanel3);
            this.Lagerzugang.Location = new System.Drawing.Point(4, 38);
            this.Lagerzugang.Name = "Lagerzugang";
            this.Lagerzugang.Size = new System.Drawing.Size(1089, 585);
            this.Lagerzugang.TabIndex = 2;
            this.Lagerzugang.Text = "Lagerzugang";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroGrid3);
            this.metroPanel3.Controls.Add(this.metroComboBox3);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer_Zugang,
            this.Bestellperiode_Zugang,
            this.Modus_Zugang,
            this.Lieferzeit_Zugang,
            this.Menge_Zugang,
            this.Preis_Zugang});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle26;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(30, 74);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(664, 206);
            this.metroGrid3.TabIndex = 4;
            // 
            // Artikelnummer_Zugang
            // 
            this.Artikelnummer_Zugang.HeaderText = "Artikelnummer";
            this.Artikelnummer_Zugang.Name = "Artikelnummer_Zugang";
            // 
            // Bestellperiode_Zugang
            // 
            this.Bestellperiode_Zugang.HeaderText = "Bestellperiode";
            this.Bestellperiode_Zugang.Name = "Bestellperiode_Zugang";
            // 
            // Modus_Zugang
            // 
            this.Modus_Zugang.HeaderText = "Bestellart";
            this.Modus_Zugang.Name = "Modus_Zugang";
            // 
            // Lieferzeit_Zugang
            // 
            this.Lieferzeit_Zugang.HeaderText = "Lieferzeit";
            this.Lieferzeit_Zugang.Name = "Lieferzeit_Zugang";
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
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(121, 26);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox3.TabIndex = 3;
            this.metroComboBox3.UseSelectable = true;
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
            this.Kennzahlen.Size = new System.Drawing.Size(1089, 585);
            this.Kennzahlen.TabIndex = 3;
            this.Kennzahlen.Text = "Kennzahlen";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroGrid4);
            this.metroPanel4.Controls.Add(this.metroComboBox4);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gewinn,
            this.GewinnDurchschnitt,
            this.GewinnGesamt,
            this.Lagerwert_Kenn,
            this.Lagerkosten_Kenn,
            this.AnzahlLager_Kenn});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid4.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroGrid4.EnableHeadersVisualStyles = false;
            this.metroGrid4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.Location = new System.Drawing.Point(30, 74);
            this.metroGrid4.Name = "metroGrid4";
            this.metroGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid4.Size = new System.Drawing.Size(671, 206);
            this.metroGrid4.TabIndex = 4;
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
            // Lagerwert_Kenn
            // 
            this.Lagerwert_Kenn.HeaderText = "Lagerwert";
            this.Lagerwert_Kenn.Name = "Lagerwert_Kenn";
            // 
            // Lagerkosten_Kenn
            // 
            this.Lagerkosten_Kenn.HeaderText = "Lagerkosten";
            this.Lagerkosten_Kenn.Name = "Lagerkosten_Kenn";
            // 
            // AnzahlLager_Kenn
            // 
            this.AnzahlLager_Kenn.HeaderText = "Anzahl Lager";
            this.AnzahlLager_Kenn.Name = "AnzahlLager_Kenn";
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Location = new System.Drawing.Point(121, 29);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox4.TabIndex = 3;
            this.metroComboBox4.UseSelectable = true;
            this.metroComboBox4.SelectedIndexChanged += new System.EventHandler(this.metroComboBox4_SelectedIndexChanged);
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
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 64;
            this.metroLink1.Location = new System.Drawing.Point(885, 23);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(94, 72);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // ErgebnisseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 684);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "ErgebnisseForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "ErgebnisseForm";
            this.Load += new System.EventHandler(this.ErgebnisseForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Lagerbestand.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lagerTortendiagramm)).EndInit();
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
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroLabel PeriodeBest;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroLabel PeriodeZugang;
        private MetroFramework.Controls.MetroGrid metroGrid4;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroLabel PeriodeKenn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer_Bestellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge_Bestellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bestellart_Bestellung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bestellperiode_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modus_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieferzeit_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge_Zugang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis_Zugang;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.DataVisualization.Charting.Chart lagerTortendiagramm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gewinn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GewinnDurchschnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GewinnGesamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagerwert_Kenn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagerkosten_Kenn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnzahlLager_Kenn;
    }
}