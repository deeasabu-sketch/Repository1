using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Sysstem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1=new Form1();
            f1.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =CS-66\SQL2025;Initial Catalog = Round70;User Id =sa;Password=jptl123456;Integrated Security = true;");
            try
            {
                if(textUserName.Text==""||textPassword.Text=="")
                {
                    MessageBox.Show("Please enter user Name and Password");
                    return;
                }
                else
                {
                    
                    String query = "Select Count(*)  from UserInfo where UserName=@username and Password=@password ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", textUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", textPassword.Text);
                   int result=(int)cmd.ExecuteScalar();
                    if(result>0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        Dashboard d = new Dashboard();
                        d.Show();
                    }
                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textPassword.Text = textUserName.Text="";
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
