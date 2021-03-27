using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        string OTP_Code /*= "0000"*/;
        public static string to;
        public static string phone;
        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.resFullNameTxt.Text = "";
            this.resMobileNoTxt.Text = "";
            this.resEmailTxt.Text = "";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rBackBtn_Click(object sender, EventArgs e)
        {
            /*=====event for go Back to login form=====*/
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }

        public void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            
        }
        

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(resEmailTxt.Text == "" || resFullNameTxt.Text == "" || resMobileNoTxt.Text == "")
            {
                MessageBox.Show("Fill in the all fields", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                send_Code();
            }
           
            
        }
        
        private void send_Code()
        {
            Random rnd = new Random();
            OTP_Code = (rnd.Next(100000, 999999)).ToString();

            string to, from, name, mail, phone;

            to = (resEmailTxt.Text).ToString();
            from = ("shamim.cse04@gmail.com").ToString();
            name = (resFullNameTxt.Text).ToString();
            phone = (resMobileNoTxt.Text).ToString();

            mail = ("Hey " + name + "!\nPhone: " + phone + " \nyour reset password \nOTP is " + OTP_Code + "\n\nThank for Using Our Services.").ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "Reset Password Verfication Code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, "S26845053a");
              
            try
            {
                smtp.Send(message);
                MessageBox.Show("Reset Password OTP Code has been Successfully sent to\n\n" + resEmailTxt.Text + ".\nCheck your email to verify. ", "Sent Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            /**/
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            if(OTP_Code == otpTxt.Text)
            {
                MessageBox.Show("Verified Successfully!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ForgotPass fp = new ForgotPass();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("OTP Code has not Matched","Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
