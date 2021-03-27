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
    public partial class ForgotPass : Form
    {
        string useremail = ForgotPassword.to;
        string usermobile = ForgotPassword.phone;

        public ForgotPass()
        {
            InitializeComponent();
        }

        /*=====CheckBox function=====*/
        public void show_password()
        {
            if (showPassCheckBox.Checked)
            {
                newPassTxt.UseSystemPasswordChar = false;
                confirmPassTxt.UseSystemPasswordChar = false;
            }
            else
            {
                newPassTxt.UseSystemPasswordChar = true;
                confirmPassTxt.UseSystemPasswordChar = true;
            }
        }
        /*=====CheckBox function end=====*/


        private void ForgotPass_Load(object sender, EventArgs e)
        {
            show_password();
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            show_password();
        }

        private void rBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }
        
        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if(newPassTxt.Text == confirmPassTxt.Text)
            {
                
                try
                {
                    /*mobile = Convert.ToInt32(usermobile.ToString());*/
                    SqlConnection con = new SqlConnection(@"Data Source=SHAMIM-PC\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");
                    string query = "Update UserInfo set Password='"+confirmPassTxt.Text+"' where Email='"+useremail+"' and Mobile_no='"+usermobile+"';";
                    
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password has been Changed Successfully!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Password has not matched!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
