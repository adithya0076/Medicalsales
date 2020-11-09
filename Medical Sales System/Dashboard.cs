using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Medical_Sales_System
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
       

        private void mtSales_Click(object sender, EventArgs e)
        {
            SalesForm frm = new SalesForm();
            frm.MdiParent = this;
            panelchildform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mtChecksales_Click(object sender, EventArgs e)
        {
            SalesCheck frm = new SalesCheck();
            frm.MdiParent = this;
            panelchildform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mtClients_Click(object sender, EventArgs e)
        {
            Clients frm = new Clients();
            frm.MdiParent = this;
            panelchildform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mtReports_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.MdiParent = this;
            panelchildform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mtSellers_Click(object sender, EventArgs e)
        {
            Seller frm = new Seller();
            frm.MdiParent = this;
            panelchildform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mtSettings_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.MdiParent = this;
            panelchildform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
  
}
