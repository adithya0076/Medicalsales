﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Forms;


namespace Medical_Sales_System
{
    public partial class NewAccount : MetroFramework.Forms.MetroForm
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-O5EMH8PD;Initial Catalog=Medical_Sales;Integrated Security=True");
        private void mtCreateNewAC_Click(object sender, EventArgs e)
        {
            if (txtPwN.Text==txtRePwN.Text)
            {
                SqlCommand cmd = new SqlCommand("insert into login_info values('" + txtEmailN.Text + "','" + txtPwN.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                epCorrect.Clear();
                epCorrect.SetError(txtRePwN, "Password Matches");
                MetroMessageBox.Show(this, "Success");
                this.Hide();
                new LoginForm().Show();

            }
            else
            {
                epWrong.Clear();
                epWrong.SetError(txtRePwN, "Doesnt Match");
            }
        }
    }
}
