namespace Medical_Sales_System
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new MetroFramework.Controls.MetroTile();
            this.btnAboutUs = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnAboutUs);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(137, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 442);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveControl = null;
            this.btnLogOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Location = new System.Drawing.Point(258, 273);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(188, 109);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogOut.TileImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.TileImage")));
            this.btnLogOut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnLogOut.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.ActiveControl = null;
            this.btnAboutUs.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAboutUs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAboutUs.Location = new System.Drawing.Point(258, 93);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(188, 109);
            this.btnAboutUs.TabIndex = 1;
            this.btnAboutUs.Text = "About us";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAboutUs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAboutUs.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.TileImage")));
            this.btnAboutUs.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAboutUs.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAboutUs.UseCustomBackColor = true;
            this.btnAboutUs.UseSelectable = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 584);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(952, 584);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(952, 584);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Lavender;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnAboutUs;
        private MetroFramework.Controls.MetroTile btnLogOut;
    }
}