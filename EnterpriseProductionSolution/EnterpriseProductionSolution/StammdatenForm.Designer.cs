namespace EnterprisePlanningSolution
{
    partial class StammdatenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StammdatenForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Artikelstamm = new System.Windows.Forms.TabPage();
            this.Stücklisten = new System.Windows.Forms.TabPage();
            this.Lager = new System.Windows.Forms.TabPage();
            this.Kosten = new System.Windows.Forms.TabPage();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this._PPS_DatenbankDataSet = new EnterprisePlanningSolution._PPS_DatenbankDataSet();
            this.artikelstammdatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikelstammdatenTableAdapter = new EnterprisePlanningSolution._PPS_DatenbankDataSetTableAdapters.ArtikelstammdatenTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verwendung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieferkosten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieferzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieferzeitabweichung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.Artikelstamm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PPS_DatenbankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelstammdatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Artikelstamm);
            this.metroTabControl1.Controls.Add(this.Stücklisten);
            this.metroTabControl1.Controls.Add(this.Lager);
            this.metroTabControl1.Controls.Add(this.Kosten);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1122, 604);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Artikelstamm
            // 
            this.Artikelstamm.AccessibleName = "Artikelstamm";
            this.Artikelstamm.AutoScroll = true;
            this.Artikelstamm.Controls.Add(this.metroGrid1);
            this.Artikelstamm.Location = new System.Drawing.Point(4, 38);
            this.Artikelstamm.Name = "Artikelstamm";
            this.Artikelstamm.Size = new System.Drawing.Size(1114, 562);
            this.Artikelstamm.TabIndex = 0;
            this.Artikelstamm.Text = "Artikelstamm";
            // 
            // Stücklisten
            // 
            this.Stücklisten.AccessibleName = "Stücklisten";
            this.Stücklisten.AutoScroll = true;
            this.Stücklisten.Location = new System.Drawing.Point(4, 38);
            this.Stücklisten.Name = "Stücklisten";
            this.Stücklisten.Size = new System.Drawing.Size(1114, 562);
            this.Stücklisten.TabIndex = 1;
            this.Stücklisten.Text = "Stücklisten";
            // 
            // Lager
            // 
            this.Lager.AccessibleName = "Lager";
            this.Lager.AutoScroll = true;
            this.Lager.Location = new System.Drawing.Point(4, 38);
            this.Lager.Name = "Lager";
            this.Lager.Size = new System.Drawing.Size(1114, 562);
            this.Lager.TabIndex = 2;
            this.Lager.Text = "Lager";
            // 
            // Kosten
            // 
            this.Kosten.AccessibleName = "Kosten";
            this.Kosten.AutoScroll = true;
            this.Kosten.Location = new System.Drawing.Point(4, 38);
            this.Kosten.Name = "Kosten";
            this.Kosten.Size = new System.Drawing.Size(1114, 562);
            this.Kosten.TabIndex = 3;
            this.Kosten.Text = "Kosten";
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 64;
            this.metroLink1.Location = new System.Drawing.Point(1041, 20);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(94, 72);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // _PPS_DatenbankDataSet
            // 
            this._PPS_DatenbankDataSet.DataSetName = "_PPS_DatenbankDataSet";
            this._PPS_DatenbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikelstammdatenBindingSource
            // 
            this.artikelstammdatenBindingSource.DataMember = "Artikelstammdaten";
            this.artikelstammdatenBindingSource.DataSource = this._PPS_DatenbankDataSet;
            // 
            // artikelstammdatenTableAdapter
            // 
            this.artikelstammdatenTableAdapter.ClearBeforeFill = true;
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
            this.Artikelnummer,
            this.Bezeichnung,
            this.Verwendung,
            this.Lieferkosten,
            this.Lieferzeit,
            this.Lieferzeitabweichung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
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
            this.metroGrid1.Size = new System.Drawing.Size(1114, 562);
            this.metroGrid1.TabIndex = 0;
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.Name = "Artikelnummer";
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.HeaderText = "Bezeichnung";
            this.Bezeichnung.Name = "Bezeichnung";
            // 
            // Verwendung
            // 
            this.Verwendung.HeaderText = "Verwendung";
            this.Verwendung.Name = "Verwendung";
            // 
            // Lieferkosten
            // 
            this.Lieferkosten.HeaderText = "Lieferkosten";
            this.Lieferkosten.Name = "Lieferkosten";
            // 
            // Lieferzeit
            // 
            this.Lieferzeit.HeaderText = "Lieferzeit";
            this.Lieferzeit.Name = "Lieferzeit";
            // 
            // Lieferzeitabweichung
            // 
            this.Lieferzeitabweichung.HeaderText = "Lieferzeitabweichung";
            this.Lieferzeitabweichung.Name = "Lieferzeitabweichung";
            // 
            // StammdatenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 684);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "StammdatenForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Stammdaten";
            this.Load += new System.EventHandler(this.StammdatenForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Artikelstamm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PPS_DatenbankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelstammdatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Artikelstamm;
        private System.Windows.Forms.TabPage Stücklisten;
        private System.Windows.Forms.TabPage Lager;
        private System.Windows.Forms.TabPage Kosten;
        private MetroFramework.Controls.MetroLink metroLink1;
        private _PPS_DatenbankDataSet _PPS_DatenbankDataSet;
        private System.Windows.Forms.BindingSource artikelstammdatenBindingSource;
        private _PPS_DatenbankDataSetTableAdapters.ArtikelstammdatenTableAdapter artikelstammdatenTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verwendung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieferkosten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieferzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieferzeitabweichung;
    }
}