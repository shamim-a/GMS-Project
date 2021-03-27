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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainAddMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMemberForm a = new AddMemberForm();
            a.Show();
        }

        private void mainUpdateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatesAndDeletes ud = new UpdatesAndDeletes();
            ud.Show();
        }

        private void mainViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewForm v = new ViewForm();
            v.Show();
        }

        private void mainPayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayForm p = new PayForm();
            p.Show();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }
    }
}
