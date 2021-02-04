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
using MySql.Data.MySqlClient;

namespace Medical_Sales_System
{
    public partial class SalesForm : MetroFramework.Forms.MetroForm
    {
        public SalesForm()
        {
            InitializeComponent();
           
        }
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=medical_sales;User id=root");
        private void btnDoctorS_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into doctor_records values('" + txtDoctorname.Text + "','" + txtProductid.Text + "','" + txtProductname.Text + "','" + txtVolume.Text + "','" + txtquantity.Text + "','" + txtSalesA.Text + "','" + dtVisit.Value.Date + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Record Saved");
                txtDoctorID.Text = "";
                txtDoctorname.Text = "";
                txtProductid.Text = "";
                txtProductname.Text = "";
                txtVolume.Text = "";
                txtquantity.Text = "";
                txtPrice.Text = "";
                txtSalesA.Text = "";
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Error");

            }
            finally
            {
                txtDoctorID.Text = "";
                txtDoctorname.Text = "";
                txtProductid.Text = "";
                txtProductname.Text = "";
                txtVolume.Text = "";
                txtquantity.Text = "";
                txtPrice.Text = "";
                txtSalesA.Text = "";

            }
        }

        private void btnPharmacyS_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into pharmacy_records values('" + txtPharamcyID.Text + "','" + txtPharmacyname.Text + "','" + txtProductid.Text + "','" + txtProductname.Text + "','" + txtVolume.Text + "','" + txtquantity.Text + "','" + txtSalesA.Text + "','" + dtVisit.Value.Date + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Record Saved");
                txtPharamcyID.Text = "";
                txtPharmacyname.Text = "";
                txtProductid.Text = "";
                txtProductname.Text = "";
                txtVolume.Text = "";
                txtquantity.Text = "";
                txtPrice.Text = "";
                txtSalesA.Text = "";
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Error");
            }
            finally
            {
                txtPharamcyID.Text = "";
                txtPharmacyname.Text = "";
                txtProductid.Text = "";
                txtProductname.Text = "";
                txtVolume.Text = "";
                txtquantity.Text = "";
                txtPrice.Text = "";
                txtSalesA.Text = "";
            }
        }
       
       

        private void txtProductname_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select product_name from products where product_ID = '" + txtProductid.Text + "'", con);

                con.Open();

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    txtProductname.Text = dr[0].ToString();
                }
                con.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void txtPharmacyname_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("select pharmacy_name from pharmacy_list where pharmacy_ID = '" + txtPharamcyID.Text + "'", con);

                con.Open();

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    txtPharmacyname.Text = dr[0].ToString();
                }
                con.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void txtDoctorname_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select doctor_name from doctor_list where doctor_ID = '" + txtDoctorID.Text + "'", con);

                con.Open();

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    txtDoctorname.Text = dr[0].ToString();
                }
                con.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void txtSalesA_Click(object sender, EventArgs e)
        {
           
            float num1 = float.Parse(txtPrice.Text);
            string stringValue = num1.ToString().Replace(',', '.');
            float num2 = float.Parse(txtquantity.Text);
            string stringValue2 = num2.ToString().Replace(',', '.');
            float total = num1 * num2;
            txtSalesA.Text = total.ToString();

        }
    }
}
