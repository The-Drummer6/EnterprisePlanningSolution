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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Artikelstamm = new System.Windows.Forms.TabPage();
            this.Stücklisten = new System.Windows.Forms.TabPage();
            this.Lager = new System.Windows.Forms.TabPage();
            this.Kosten = new System.Windows.Forms.TabPage();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this._PPS_DatenbankDataSet = new EnterprisePlanningSolution._PPS_DatenbankDataSet();
            this.artikelstammdatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikelstammdatenTableAdapter = new EnterprisePlanningSolution._PPS_DatenbankDataSetTableAdapters.ArtikelstammdatenTableAdapter();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PPS_DatenbankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelstammdatenBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this._PPS_DatenbankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelstammdatenBindingSource)).EndInit();
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
    }
}