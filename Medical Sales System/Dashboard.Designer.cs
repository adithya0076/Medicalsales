namespace Medical_Sales_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.mtSettings = new MetroFramework.Controls.MetroTile();
            this.mtReports = new MetroFramework.Controls.MetroTile();
            this.mtSellers = new MetroFramework.Controls.MetroTile();
            this.mtClients = new MetroFramework.Controls.MetroTile();
            this.mtChecksales = new MetroFramework.Controls.MetroTile();
            this.mtSales = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtSettings
            // 
            this.mtSettings.ActiveControl = null;
            this.mtSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtSettings.Location = new System.Drawing.Point(-4, 509);
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.Size = new System.Drawing.Size(198, 75);
            this.mtSettings.TabIndex = 11;
            this.mtSettings.Text = "Settings";
            this.mtSettings.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSettings.TileImage")));
            this.mtSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSettings.UseSelectable = true;
            this.mtSettings.UseTileImage = true;
            this.mtSettings.Click += new System.EventHandler(this.mtSettings_Click);
            // 
            // mtReports
            // 
            this.mtReports.ActiveControl = null;
            this.mtReports.Location = new System.Drawing.Point(-4, 303);
            this.mtReports.Name = "mtReports";
            this.mtReports.Size = new System.Drawing.Size(198, 75);
            this.mtReports.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtReports.TabIndex = 11;
            this.mtReports.Text = "Reports";
            this.mtReports.TileImage = ((System.Drawing.Image)(resources.GetObject("mtReports.TileImage")));
            this.mtReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtReports.UseSelectable = true;
            this.mtReports.UseTileImage = true;
            this.mtReports.Click += new System.EventHandler(this.mtReports_Click);
            // 
            // mtSellers
            // 
            this.mtSellers.ActiveControl = null;
            this.mtSellers.Location = new System.Drawing.Point(0, 405);
            this.mtSellers.Name = "mtSellers";
            this.mtSellers.Size = new System.Drawing.Size(194, 75);
            this.mtSellers.TabIndex = 10;
            this.mtSellers.Text = "Sellers";
            this.mtSellers.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSellers.TileImage")));
            this.mtSellers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSellers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSellers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSellers.UseSelectable = true;
            this.mtSellers.UseTileImage = true;
            this.mtSellers.Click += new System.EventHandler(this.mtSellers_Click);
            // 
            // mtClients
            // 
            this.mtClients.ActiveControl = null;
            this.mtClients.Location = new System.Drawing.Point(-4, 200);
            this.mtClients.Name = "mtClients";
            this.mtClients.Size = new System.Drawing.Size(198, 84);
            this.mtClients.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtClients.TabIndex = 8;
            this.mtClients.Text = "Clients and \r\nStock";
            this.mtClients.TileImage = ((System.Drawing.Image)(resources.GetObject("mtClients.TileImage")));
            this.mtClients.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtClients.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtClients.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtClients.UseSelectable = true;
            this.mtClients.UseTileImage = true;
            this.mtClients.Click += new System.EventHandler(this.mtClients_Click);
            // 
            // mtChecksales
            // 
            this.mtChecksales.ActiveControl = null;
            this.mtChecksales.Location = new System.Drawing.Point(-4, 95);
            this.mtChecksales.Name = "mtChecksales";
            this.mtChecksales.Size = new System.Drawing.Size(198, 75);
            this.mtChecksales.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtChecksales.TabIndex = 9;
            this.mtChecksales.Text = "Check Sales";
            this.mtChecksales.TileImage = ((System.Drawing.Image)(resources.GetObject("mtChecksales.TileImage")));
            this.mtChecksales.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtChecksales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtChecksales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtChecksales.UseSelectable = true;
            this.mtChecksales.UseTileImage = true;
            this.mtChecksales.Click += new System.EventHandler(this.mtChecksales_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.ForeColor = System.Drawing.Color.Ivory;
            this.mtSales.Location = new System.Drawing.Point(0, 0);
            this.mtSales.Name = "mtSales";
            this.mtSales.Size = new System.Drawing.Size(194, 75);
            this.mtSales.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtSales.TabIndex = 7;
            this.mtSales.Text = "Sales";
            this.mtSales.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSales.TileImage")));
            this.mtSales.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSales.UseCustomForeColor = true;
            this.mtSales.UseSelectable = true;
            this.mtSales.UseTileImage = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mtReports);
            this.metroPanel1.Controls.Add(this.mtSellers);
            this.metroPanel1.Controls.Add(this.mtSales);
            this.metroPanel1.Controls.Add(this.mtSettings);
            this.metroPanel1.Controls.Add(this.mtChecksales);
            this.metroPanel1.Controls.Add(this.mtClients);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(194, 584);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panelchildform
            // 
            this.panelchildform.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelchildform.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelchildform.Location = new System.Drawing.Point(237, 63);
            this.panelchildform.MaximumSize = new System.Drawing.Size(952, 584);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(952, 584);
            this.panelchildform.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 667);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelchildform);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1210, 667);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtSettings;
        private MetroFramework.Controls.MetroTile mtReports;
        private MetroFramework.Controls.MetroTile mtSellers;
        private MetroFramework.Controls.MetroTile mtClients;
        private MetroFramework.Controls.MetroTile mtChecksales;
        private MetroFramework.Controls.MetroTile mtSales;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panelchildform;
    }
}