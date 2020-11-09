using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Sales_System
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
         
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                Settings md1 = (Settings)this.MdiParent;
                md1.Visible = false;
              
            }   catch (Exception ex)
            {

            } 
            new LoginForm().Show();
        }
    }
}
