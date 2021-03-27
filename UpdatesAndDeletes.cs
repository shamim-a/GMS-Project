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
    public partial class UpdatesAndDeletes : Form
    {
        public UpdatesAndDeletes()
        {
            InitializeComponent();
        }

        private void newMemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdatesAndDeletes_Load(object sender, EventArgs e)
        {
            genderCombo.SelectedIndex = 0;
            timeCombo.SelectedIndex = 0;
            members();
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
            memView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void memMobileNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f = new MainForm();
            f.Show();
        }
        int key=0;
        private void memView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*view list event*/

            key = Convert.ToInt32(memView.SelectedRows[0].Cells[0].Value.ToString());
            memFirstNameTxt.Text = memView.SelectedRows[0].Cells[1].Value.ToString();
            memLastNameTxt.Text = memView.SelectedRows[0].Cells[2].Value.ToString();
            memMobileNo.Text = memView.SelectedRows[0].Cells[3].Value.ToString();
            memAgeTxt.Text = memView.SelectedRows[0].Cells[4].Value.ToString();
            genderCombo.Text = memView.SelectedRows[0].Cells[5].Value.ToString();
            memAmountTxt.Text = memView.SelectedRows[0].Cells[6].Value.ToString();
            timeCombo.Text = memView.SelectedRows[0].Cells[7].Value.ToString();
            addressTxt.Text = memView.SelectedRows[0].Cells[8].Value.ToString();
            memEmail.Text = memView.SelectedRows[0].Cells[9].Value.ToString();
        }

        public void clear()
        {
            memFirstNameTxt.Text = "";
            memLastNameTxt.Text ="";
            memMobileNo.Text = "";
            memAgeTxt.Text ="";
            memEmail.Text = "";
            genderCombo.SelectedIndex = 0;
            timeCombo.SelectedIndex = 0;
            addressTxt.Text = "";
            memAmountTxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Delete butten event*/

            if (key == 0)
            {
                MessageBox.Show("Selecet a Member to be Deleted.");
            }
            else
            {
                try
                {
                    DialogResult dm = MessageBox.Show("Are you wanted to Delete '" + memFirstNameTxt.Text + " " + memLastNameTxt.Text + "'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dm == DialogResult.Yes)
                    {
                        con.Open();
                        string qry = "delete from MemTable where MId=" + key +";";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Has been Successfully deleted.");
                        con.Close();
                        members();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Member has not be Deleted!");
                    }

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            /*Delete butten event end*/
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*Update butten event*/

            if (key == 0 || memFirstNameTxt.Text == "" || memLastNameTxt.Text == "" || memMobileNo.Text == "" || memAgeTxt.Text == "" || memEmail.Text == "" || genderCombo.SelectedIndex == 0 || memAmountTxt.Text == "" || timeCombo.SelectedIndex == 0 || addressTxt.Text == "")
            {
                MessageBox.Show("Selecet a Member to be Updated.");
            }
            else
            {
                try
                {
                    DialogResult dm = MessageBox.Show("Are you wanted to Update as '" + memFirstNameTxt.Text + " " + memLastNameTxt.Text + "'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dm == DialogResult.Yes)
                    {
                        con.Open();
                        string qry = "update MemTable set MFname='"+memFirstNameTxt.Text+ "', MLname='"+memLastNameTxt.Text+ "', MPhone='"+memMobileNo.Text+ "', MAge="+memAgeTxt.Text+", MGen='"+genderCombo.Text+ "', MAmount="+memAmountTxt.Text+ ", MTiming='"+timeCombo.Text+ "', MAddress='"+addressTxt.Text+ "', MEmail = '" + memEmail.Text+"' where MId=" + key + ";";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Has been Updated Successfully.");
                        con.Close();
                        members();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Member has not be updated!");
                    }

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            /*Update butten event end*/
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }
    }
}
