namespace EnterprisePlanningSolution
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.epsLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.usernameTextBox.CustomButton.Image = null;
            this.usernameTextBox.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.usernameTextBox.CustomButton.Name = "";
            this.usernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.CustomButton.TabIndex = 1;
            this.usernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.CustomButton.UseSelectable = true;
            this.usernameTextBox.CustomButton.Visible = false;
            this.usernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(290, 46);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PromptText = "Username";
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(90, 23);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.WaterMark = "Username";
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 64;
            this.metroLink1.Location = new System.Drawing.Point(290, 119);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(94, 80);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(290, 75);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PromptText = "Password";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(90, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMark = "Password";
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.usernameTextBox);
            this.metroPanel1.Controls.Add(this.passwordTextBox);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 137);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(674, 202);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // epsLabel1
            // 
            this.epsLabel1.AutoSize = true;
            this.epsLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.epsLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.epsLabel1.Location = new System.Drawing.Point(209, 60);
            this.epsLabel1.Name = "epsLabel1";
            this.epsLabel1.Size = new System.Drawing.Size(254, 25);
            this.epsLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.epsLabel1.TabIndex = 4;
            this.epsLabel1.Text = "Enterprise Planning Solution";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.epsLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroLabel epsLabel1;
    }
}

