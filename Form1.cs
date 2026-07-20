using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Sysstem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source =CS-66\SQL2025;Initial Catalog = Round70;User Id =sa;Password=jptl123456;Integrated Security = true;");
            try
            {
                if (textUserName.Text == "" || textPassword.Text == "")
                {
                    MessageBox.Show("Please Fill all the requied data");
                    return;
                }
                else
                {
                    con.Open();
                    string checkUser = "Select count(*) from UserInfo where UserName=@username";
                    SqlCommand cmd = new SqlCommand(checkUser,con);
                    cmd.Parameters.AddWithValue("@username", textUserName.Text);
                    int existUser = (int)cmd.ExecuteScalar();
                    if (existUser >0)
                    {
                        MessageBox.Show("UserName Already Exists");
                        return;

                    }
                    else
                    {
                        string insertQuery = "Insert into UserInfo (FullName,UserName,Password) values(@FullName,@UserName,@Password)";
                        SqlCommand sqlcmd = new SqlCommand(insertQuery, con);
                        sqlcmd.Parameters.AddWithValue("@FullName", textFullName.Text);
                        sqlcmd.Parameters.AddWithValue("@UserName", textUserName.Text);
                        sqlcmd.Parameters.AddWithValue("@password", textPassword.Text);
                        int rows = sqlcmd.ExecuteNonQuery();
                        if (rows>0)
                        {
                            MessageBox.Show("Register Successfully");
                            textFullName.Clear();
                            textUserName.Clear();
                            textPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Register failed");
                        }



                    }

                }
                

                
            }
            catch (Exception ex) 
            {

             MessageBox.Show("Error :"+ex.Message);

            }
            finally
            {
                con.Close();
            }

            
        }
    }
}
