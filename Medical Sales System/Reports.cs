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
using KimToo;
using MySql.Data.MySqlClient;


namespace Medical_Sales_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=medical_sales;User id=root");


        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbChoice.SelectedIndex == 0)
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from doctor_records", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvSales.DataSource = dt;
            }
            if (cbChoice.SelectedIndex == 1)
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from pharmacy_records", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvSales.DataSource = dt;
            }
        }
        private void btnDoctorS_Click(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 0)
            {
                EasyHTMLReports frm = new EasyHTMLReports();
                frm.AddImage(pbLogo.Image, "width=254");

                frm.AddLineBreak();
               frm.AddString("<h3>Doctor Sales</h3>");

               frm.AddHorizontalRule();
               frm.AddDatagridView(dgvSales);
                frm.ShowPrintPreviewDialog();
            }
        }

        private void btnPharmacyS_Click(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 1)
            {

                EasyHTMLReports frm = new EasyHTMLReports();
                frm.AddImage(pbLogo.Image, "width=254");

                frm.AddLineBreak();
                frm.AddString("<h3>Pharmacy Sales</h3>");

                frm.AddHorizontalRule();
                frm.AddDatagridView(dgvSales);
                frm.ShowPrintPreviewDialog();
            }
        }
    }
}
