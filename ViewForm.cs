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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void UpdlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Events for Back*/
            this.Hide();
            MainForm m = new MainForm();
            m.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAMIM-PC\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");

        private void members()
        {
            con.Open();
            string qry = "Select * From MemTable";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            SqlCommandBuilder builder =  new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            memView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                members();
            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void filterByname()
        {
            con.Open();
            string qry = "Select * From MemTable where MFname = '" + searchTxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);

            var ds = new DataSet();
            sda.Fill(ds);
            memView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            filterByname();
            searchTxt.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            members();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }
    }
}
