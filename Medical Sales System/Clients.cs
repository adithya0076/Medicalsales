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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            txtVolume.Visible = false;
            lblVolume.Visible = false;
            txtPrice.Visible = false;
            lblPrice.Visible = false;
        }
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=medical_sales;User id=root");
        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 0)
            {
                txtVolume.Visible = false;
                lblVolume.Visible = false;
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from doctor_list", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
               dgvList.DataSource = dt;
               

            }
            if (cbChoice.SelectedIndex == 1)
            {
                txtVolume.Visible = false;
                lblVolume.Visible = false;
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from pharmacy_list", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvList.DataSource = dt;
              
               
            }
            if (cbChoice.SelectedIndex == 2)
            {
                txtVolume.Visible = true;
                lblVolume.Visible = true;
                txtPrice.Visible = true;
                lblPrice.Visible = true;
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from products", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                con.Close();
                dgvList.DataSource = dt;
            }
        }

      
        private void txtEnter_Click(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 0)
            {
                MySqlCommand cmd = new MySqlCommand("insert into doctor_list values('" + txtID.Text + "','" + txtName.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Record Saved");
                txtID.Text = "";
                txtName.Text = "";
            }
            if(cbChoice.SelectedIndex==1)
            {
                MySqlCommand cmd = new MySqlCommand("insert into pharmacy_list values('" + txtID.Text + "','" + txtName.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Record Saved");
                txtID.Text = "";
                txtName.Text = "";
            }
            if(cbChoice.SelectedIndex==2)
            {
                MySqlCommand cmd = new MySqlCommand("insert into products values('" + txtID.Text + "','" + txtName.Text + "','"+txtVolume.Text+"','"+txtPrice.Text+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MetroMessageBox.Show(this, "Record Saved");
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtVolume.Text = "";
            }
            
        }
    }
}
