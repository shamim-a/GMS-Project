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

namespace Gym_Management_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            regActCombo.SelectedIndex = 0;
            show_password();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*=====CheckBox function=====*/
        public void show_password()
        {
            if (showPassCheckBox.Checked)
            {
                regPasswordTxt.isPassword = false;
            }
            else
            {
                regPasswordTxt.isPassword = true;
            }
        }
        /*=====CheckBox function end=====*/

        private void regBackBtn_Click(object sender, EventArgs e)
        {  /*=====event for go Back to login form=====*/
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            regFirstNameTxt.Text = "";
            regLastNameTxt.Text = "";
            regMobileNo.Text = "";
            regPasswordTxt.Text = "";
            regUserNameTxt.Text = "";
            addressTxt.Text = "";
            regEmailTxt.Text = "";
            regActCombo.SelectedIndex = 0;
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            show_password();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHAMIM-PC\\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");
            if (regActCombo.SelectedIndex == 0)
            {
                MessageBox.Show("Error! Role Selection Mendatory.");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[UserInfo]
           ([First_Name]
           ,[Last_Name]
           ,[Role]
           ,[Username]
           ,[Password]
           ,[Mobile_no]
           ,[Address]
           ,[Email])
     VALUES
           ('" + regFirstNameTxt.Text + "', '" + regLastNameTxt.Text + "', '" + regActCombo.SelectedItem.ToString() + "', '" + regUserNameTxt.Text + "', '" + regPasswordTxt.Text + "', '" + regMobileNo.Text + "', '" + addressTxt.Text + "' , '" + regEmailTxt.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("" + regFirstNameTxt.Text + " as " + regActCombo.SelectedItem.ToString() + " Registration Successful");
                    con.Close();
                    regBackBtn_Click(sender, e);

                }
                catch(Exception exp)
                {
                    MessageBox.Show("Something went wrong! Tray again." +exp.Message);
                }
            }
            
        }
    }
}
