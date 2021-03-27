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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*=====CheckBox function=====*/
        public void show_password()
        {
            if (showPassCheckBox.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
        }
        /*=====CheckBox function end=====*/

        private void logClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*=====using CheckBox function=====*/
            show_password();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*=====using CheckBox function=====*/
            show_password();
            roleCombo.SelectedIndex = 0;
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   /*=====event for go to Sign Up form=====*/
            this.Hide();
            SignUp s = new SignUp();
            s.Show();
        }

        private void forgotPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*=====event for go to Forgot Password form=====*/

            this.Hide();
            ForgotPassword reset = new ForgotPassword();
            reset.Show();
        }

        private void userNameTxt_DoubleClick(object sender, EventArgs e)
        {   
            /*=====clear Event=====*/

            userNameTxt.Text = "";
            passwordTxt.Text = "";
            roleCombo.SelectedIndex = 0;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        { 
            /*=====SQL server connection*/
            SqlConnection con = new SqlConnection("Data Source=SHAMIM-PC\\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");
            if (userNameTxt.Text==""|| passwordTxt.Text=="")
            {
                MessageBox.Show("Failed ! Fill up all Mendatory");
            }
                else
                {
                    try
                {
                    SqlCommand cmd = new SqlCommand();
                    string role = roleCombo.SelectedItem.ToString();
                    string username = userNameTxt.Text.ToString();
                    string pass = passwordTxt.Text.ToString();
                    string qry = "Select Username, Password, Role from UserInfo where Username='" + username + "' and  Password='" + pass + "' and Role='" + role + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["Role"].ToString() == role)
                            {
                                MessageBox.Show("You are Log in as " + dt.Rows[i][2]);
                                if (roleCombo.SelectedIndex == 1)
                                {
                                    MainForm f = new MainForm();
                                    f.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    DashBoard p = new DashBoard();
                                    p.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalied User Login ! Try again.");
                    }
                }
                    
                    catch (Exception exp)
                    {
                    MessageBox.Show(exp.Message);
                    }
                }            
        }
    }
}

