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
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace Medical_Sales_System
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=medical_sales;User id=root");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from login_info where email = '"+txtEmail.Text+"' and password = '"+txtPassword.Text+"'",con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                epCorrect.Clear();
                epCorrect.SetError(btnLogin, "Login Success");
               
                timer1.Enabled = true;
                
             
            }
            else
           {
                epWrong.Clear();
                epWrong.SetError(btnLogin, "Invalid Login");
               
                txtPassword.Text = "";
              
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewAccount().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbLogin.Value = pbLogin.Value + 2;
            if (pbLogin.Value > 99)
            {
                timer1.Enabled = false;
                this.Hide();
                new Dashboard().Show();
            }
        }
    }
}
