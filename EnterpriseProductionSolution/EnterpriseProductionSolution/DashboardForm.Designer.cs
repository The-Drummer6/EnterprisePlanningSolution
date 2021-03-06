﻿namespace EnterprisePlanningSolution
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.resetButton = new MetroFramework.Controls.MetroLink();
            this.beendenButton = new MetroFramework.Controls.MetroLink();
            this.SpracheComboDashboard = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(38, 278);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(227, 120);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "XML Import";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(324, 115);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(227, 120);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Periodenplanung";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(38, 115);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(227, 120);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Stammdaten";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(324, 278);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(227, 120);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Planungsergebnisse";
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // resetButton
            // 
            this.resetButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.resetButton.ImageSize = 64;
            this.resetButton.Location = new System.Drawing.Point(391, 23);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 72);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // beendenButton
            // 
            this.beendenButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.beendenButton.ImageSize = 64;
            this.beendenButton.Location = new System.Drawing.Point(1019, 23);
            this.beendenButton.Name = "beendenButton";
            this.beendenButton.Size = new System.Drawing.Size(94, 72);
            this.beendenButton.TabIndex = 5;
            this.beendenButton.Text = "Logout";
            this.beendenButton.UseSelectable = true;
            this.beendenButton.Click += new System.EventHandler(this.beendenButton_Click);
            // 
            // SpracheComboDashboard
            // 
            this.SpracheComboDashboard.FormattingEnabled = true;
            this.SpracheComboDashboard.ItemHeight = 23;
            this.SpracheComboDashboard.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.SpracheComboDashboard.Location = new System.Drawing.Point(501, 46);
            this.SpracheComboDashboard.Name = "SpracheComboDashboard";
            this.SpracheComboDashboard.Size = new System.Drawing.Size(121, 29);
            this.SpracheComboDashboard.TabIndex = 6;
            this.SpracheComboDashboard.UseSelectable = true;
            this.SpracheComboDashboard.SelectedIndexChanged += new System.EventHandler(this.SpracheComboDashboard_SelectedIndexChanged);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 684);
            this.Controls.Add(this.SpracheComboDashboard);
            this.Controls.Add(this.beendenButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "DashboardForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Enterprise Planning Solution";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroLink resetButton;
        private MetroFramework.Controls.MetroLink beendenButton;
        private MetroFramework.Controls.MetroComboBox SpracheComboDashboard;
    }
}