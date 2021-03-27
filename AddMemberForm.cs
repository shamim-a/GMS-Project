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
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAMIM-PC\MSSQLSERVER1;Initial Catalog=GMSDB;Integrated Security=True");
        private void newMemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            memGenderCombo.SelectedIndex =0;
            memTimeCombo.SelectedIndex = 0;
        }

        private void memBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.Show();
        }

        private void addMemResBtn_Click(object sender, EventArgs e)
        {
            memFirstNameTxt.Text = "";
            memLastNameTxt.Text = "";
            memMobileNo.Text = "";
            memberAgeTxt.Text = "";
            memGenderCombo.SelectedIndex = 0;
            memTimeCombo.SelectedIndex = 0;
            addressTxt.Text = "";
            monthlyAmnTxt.Text = "";
            memEmailTxt.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                if (memFirstNameTxt.Text ==""|| memLastNameTxt.Text == ""|| memMobileNo.Text ==""|| memGenderCombo.SelectedIndex==0 || memEmailTxt.Text==""||memTimeCombo.SelectedIndex==0||monthlyAmnTxt.Text=="")

            {
                MessageBox.Show("Error, Missing information could not be added.");
            }
                else
            {
                try
                {
                    con.Open();
                    string qry = "insert into MemTable values ('"+memFirstNameTxt.Text+"', '"+memLastNameTxt.Text+"'," +
                        " '"+memMobileNo.Text+"','"+memberAgeTxt.Text+"', '"+memGenderCombo.SelectedItem.ToString()+"'," +
                        "'"+monthlyAmnTxt.Text+"', '"+memTimeCombo.SelectedItem.ToString()+"','"+addressTxt.Text+"'," +
                        "'"+memEmailTxt.Text+"'" +
                        ")";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member "+memFirstNameTxt.Text+" is Added Suceesful");
                    con.Close();
                    addMemResBtn_Click(sender, e);

                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }
    }
}
