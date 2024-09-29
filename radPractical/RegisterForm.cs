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

namespace radPractical
{
    public partial class RegisterForm : Form
    {
        //making connection to local database using connection string
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signup_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginReg_btn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPwd_CheckedChanged(object sender, EventArgs e)
        {
            signup_pwd.PasswordChar = signup_showPwd.Checked ? '\0' : '*';
        }

        private void signupReg_btn_Click(object sender, EventArgs e)
        {
            if (signup_uname.Text == "" || signup_pwd.Text == "")//checking empty 
            {
                MessageBox.Show("Fill all text field!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("feild empty");
                Console.ReadLine();
            }
            else {
                if (conn.State != ConnectionState.Open) {
                    try
                    {   //open connection
                        conn.Open();
                        Console.WriteLine("Connection open!");
                        Console.ReadLine();

                        //checking enterd username and password already exisit or not
                        String selectUsername = "select count(id) from users where username=@uname";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, conn)) {
                            checkUser.Parameters.AddWithValue("@uname", signup_uname.Text.Trim());
                            int count = (int) checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_uname.Text.Trim() + " username is already taken", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                DateTime today = DateTime.Today;
                                string insertData = "insert into users (username,password,date_reg) values(@uname,@pwd,@reg_date)";
                                Console.WriteLine("inserting query!");
                                Console.ReadLine();
                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@uname", signup_uname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pwd", signup_pwd.Text.Trim());
                                    cmd.Parameters.AddWithValue("@reg_date", today);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registerd successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();

                                }

                            }
                        
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { 
                        conn.Close();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
