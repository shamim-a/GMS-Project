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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAMIM-PC\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");

        private void fillName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select MFname, MLname from MemTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MFname", typeof(string));
            /*dt.Columns.Add("MLname", typeof(string));*/
            dt.Load(rdr);
            nameCombo.ValueMember = "MFname";
            /*nameCombo.ValueMember = ;*/
            nameCombo.DataSource = dt;
            con.Close();
        }

        private void members()
        {
            con.Open();
            string qry = "Select * From PaymentTable";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            
            var ds = new DataSet();
            sda.Fill(ds);
            payView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void filterByname()
        {
            con.Open();
            string qry = "Select * From PaymentTable where PMember = '"+searchBox.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);

            var ds = new DataSet();
            sda.Fill(ds);
            payView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {   
            /*Back to main form*/

            this.Hide();
            MainForm f = new MainForm();
            f.Show();
        }

        private void UpdlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            monthlyAmnTxt.Text = "";
            emailTxt.Text = "";
            nameCombo.SelectedIndex = 0;
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            fillName();
            members();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (nameCombo.Text == "" || monthlyAmnTxt.Text =="")
            {
                MessageBox.Show("Select a name and fill amount", "Mandetory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string payPeriod = dateTime.Value.Month.ToString() + dateTime.Value.Year.ToString();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PaymentTable where PMember='"+nameCombo.SelectedValue.ToString()+"' and PEmail = '"+emailTxt.Text.ToString()+"' and PMonth='"+payPeriod+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                /*Check the condition of Each row hasbeen paid*/
                if(dt.Rows[0][0].ToString()== "1")
                {
                    MessageBox.Show("Selected Member Already Paid for this Month.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string query = "Insert into PaymentTable values ('"+nameCombo.SelectedValue.ToString()+"', '"+emailTxt.Text+"', '"+payPeriod+"','"+monthlyAmnTxt.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Member "+nameCombo.SelectedValue.ToString()+"\n\nSuccessfully Paid for this"+payPeriod+"", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                members();
            }
        }

        private void memView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            filterByname();
            searchBox.Text = "";
        }

        private void reloadBtn_Click(object sender, EventArgs e)
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
