using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Profile_Update : Form
    {
        public Profile_Update()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dsf = new DashBoard();
            dsf.Show();
        }

        
        SqlConnection con = new SqlConnection(@"Data Source=SHAMIM-PC\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");

        private void members()
        {
            con.Open();
            string qry = "Select * From MemTable";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            /*memView.DataSource = ds.Tables[0];*/
            con.Close();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            /*Sign out button event */
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }
    }
}
