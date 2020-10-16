using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using MetroFramework;

namespace Medical_Sales_System
{
    public partial class SalesCheck : Form
    {
        public SalesCheck()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-O5EMH8PD;Initial Catalog=Medical_Sales;Integrated Security=True");
        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbChoice.SelectedIndex == 0)
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from doctor_records",con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvSales.DataSource = dt;
            }
            if(cbChoice.SelectedIndex == 1)
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from pharmacy_records", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvSales.DataSource = dt;
            }
        }
    }
}
