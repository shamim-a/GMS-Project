using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            Profile_Update pu = new Profile_Update();
            pu.Show();
            this.Hide();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void logClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
