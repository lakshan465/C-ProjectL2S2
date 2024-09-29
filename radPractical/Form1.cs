using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace radPractical
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //hello

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterForm regsterForm = new RegisterForm(); 
            regsterForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_uname.Text == "" || login_pwd.Text == "")
            {

                MessageBox.Show("Fill all text field!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        string selectData = "select * from users where username=@uname and password=@pwd";
                        using (SqlCommand cmd = new SqlCommand(selectData, conn)) {
                            cmd.Parameters.AddWithValue("@uname", login_uname.Text.Trim());
                            cmd.Parameters.AddWithValue("@pwd", login_pwd.Text.Trim());
                           
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mainForm = new MainForm(); 
                                mainForm.Show();
                                this.Hide();
                            
                            }
                            else {
                                MessageBox.Show("Incorrect username or password", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_showPwd_CheckedChanged(object sender, EventArgs e)
        {
            login_pwd.PasswordChar = login_showPwd.Checked ? '\0' : '*';
        }
    }
}
