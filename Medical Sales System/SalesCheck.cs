using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace Medical_Sales_System
{
    public partial class SalesCheck : Form
    {
        public SalesCheck()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=medical_sales;User id=root");
        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbChoice.SelectedIndex == 0)
            {
               MySqlDataAdapter adp = new MySqlDataAdapter("select * from doctor_records",con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvSales.DataSource = dt;
            }
            if(cbChoice.SelectedIndex == 1)
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from pharmacy_records", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvSales.DataSource = dt;
            }
        }
    }
}
