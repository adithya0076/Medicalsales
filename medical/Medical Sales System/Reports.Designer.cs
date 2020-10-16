namespace Medical_Sales_System
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnPharmacyS = new MetroFramework.Controls.MetroTile();
            this.btnDoctorS = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.easyHTMLReports1 = new KimToo.EasyHTMLReports(this.components);
            this.cbChoice = new MetroFramework.Controls.MetroComboBox();
            this.dgvSales = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(-5, -2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(937, 540);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnPharmacyS
            // 
            this.btnPharmacyS.ActiveControl = null;
            this.btnPharmacyS.BackColor = System.Drawing.Color.Purple;
            this.btnPharmacyS.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPharmacyS.Location = new System.Drawing.Point(688, 207);
            this.btnPharmacyS.Name = "btnPharmacyS";
            this.btnPharmacyS.Size = new System.Drawing.Size(168, 96);
            this.btnPharmacyS.TabIndex = 1;
            this.btnPharmacyS.Text = "Pharmacy Sales";
            this.btnPharmacyS.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPharmacyS.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPharmacyS.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPharmacyS.UseCustomBackColor = true;
            this.btnPharmacyS.UseCustomForeColor = true;
            this.btnPharmacyS.UseSelectable = true;
            this.btnPharmacyS.UseStyleColors = true;
            this.btnPharmacyS.Click += new System.EventHandler(this.btnPharmacyS_Click);
            // 
            // btnDoctorS
            // 
            this.btnDoctorS.ActiveControl = null;
            this.btnDoctorS.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDoctorS.Location = new System.Drawing.Point(688, 87);
            this.btnDoctorS.Name = "btnDoctorS";
            this.btnDoctorS.Size = new System.Drawing.Size(168, 97);
            this.btnDoctorS.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDoctorS.TabIndex = 2;
            this.btnDoctorS.Text = "Doctor Sales";
            this.btnDoctorS.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDoctorS.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDoctorS.UseCustomBackColor = true;
            this.btnDoctorS.UseCustomForeColor = true;
            this.btnDoctorS.UseSelectable = true;
            this.btnDoctorS.UseStyleColors = true;
            this.btnDoctorS.UseTileImage = true;
            this.btnDoctorS.Click += new System.EventHandler(this.btnDoctorS_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(688, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Print Preview";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // easyHTMLReports1
            // 
            this.easyHTMLReports1.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports1.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.easyHTMLReports1.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports1.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports1.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports1.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports1.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // cbChoice
            // 
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.ItemHeight = 24;
            this.cbChoice.Items.AddRange(new object[] {
            "Doctor Sales ",
            "Pharmacy Sales"});
            this.cbChoice.Location = new System.Drawing.Point(34, 207);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(184, 30);
            this.cbChoice.TabIndex = 5;
            this.cbChoice.UseSelectable = true;
            this.cbChoice.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSales.Location = new System.Drawing.Point(34, 268);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(591, 239);
            this.dgvSales.TabIndex = 6;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 537);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.cbChoice);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDoctorS);
            this.Controls.Add(this.btnPharmacyS);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(952, 584);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(952, 584);
            this.Name = "Reports";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroTile btnPharmacyS;
        private MetroFramework.Controls.MetroTile btnDoctorS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private KimToo.EasyHTMLReports easyHTMLReports1;
        private MetroFramework.Controls.MetroComboBox cbChoice;
        private MetroFramework.Controls.MetroGrid dgvSales;
    }
}