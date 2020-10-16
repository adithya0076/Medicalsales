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

namespace Medical_Sales_System
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-O5EMH8PD;Initial Catalog=Medical_Sales;Integrated Security=True");
        private void dgvSeller_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from distributor", con);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            dgvSeller.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string district = txtDistrict.Text;
            string province = txtProvince.Text;
            string country = txtCountry.Text;
            StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=&#8221");
           if (district !=txtDistrict.Text) 
{
                location.Append(district + "," + "+");
            }
            if (province !=txtProvince.Text)
{
                location.Append(province + "," + "+");
            }
            if (country !=txtCountry.Text) 
{
                location.Append(country + "," + "+");
            }
            Browser1.Navigate(location.ToString());
        }
    }
}
