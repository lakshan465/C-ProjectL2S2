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
using System.IO;

namespace radPractical
{
    public partial class AddEmployee : UserControl
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AddEmployee()
        {
            InitializeComponent();

            //data that retrive from database display in interface
            displayEmployeeData();
        }
        public void displayEmployeeData() { 
            EmployeeData empd = new EmployeeData();
            List<EmployeeData> listData = empd.employeeListData();
            dataGridView1.DataSource = listData;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addEmp_add_btn_Click(object sender, EventArgs e)
        {
            if (addEmp_id.Text == "" || addEmp_fullName.Text == "" || addEmp_tp.Text == "" || addEmp_gender.Text == "" || addEmp_position.Text == "" || addEmp_status.Text == "" || addEmp_img.Image == null)
            {
                MessageBox.Show("Fill all text field!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                if (conn.State == ConnectionState.Closed) {
                    try {
                        conn.Open();
                        string checkEmpid = "select count(*) from employee where employee_id =@empId";

                        using (SqlCommand cmd1 = new SqlCommand(checkEmpid, conn)) {
                            cmd1.Parameters.AddWithValue("@empId", addEmp_id.Text.Trim());
                            int count = (int)cmd1.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show(addEmp_id.Text.Trim()+" id already taken!" , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else {
                                DateTime today = DateTime.Today;
                                string insertData = "insert into employee " +
                                    "(employee_id,full_name,gender,tele_no,position,image,insert_date,ststus) " +
                                    "values(@emp_id,@fname,@gen,@tel,@position,@img,@insertDate,@satatus)";

                                string path = Path.Combine(@"C:\Users\user\Documents\GitHub\RADproject\radPractical\Dir\"
                                + addEmp_id.Text.Trim()+".jpg");//depend on computer

                                string dirPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(dirPath)) { 
                                    Directory.CreateDirectory(dirPath);
                                }
                                File.Copy(addEmp_img.ImageLocation, path, true);

                                using (SqlCommand cmd2 = new SqlCommand(insertData, conn)) {

                                    cmd2.Parameters.AddWithValue("@emp_id", addEmp_id.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@fname", addEmp_fullName.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@gen", addEmp_gender.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@tel", addEmp_tp.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@position", addEmp_position.Text.Trim());
                                    //cmd2.Parameters.AddWithValue("@salary", addEmp_id.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@img", path);//double check
                                    cmd2.Parameters.AddWithValue("@insertDate", today);
                                    cmd2.Parameters.AddWithValue("@satatus", addEmp_status.Text.Trim());

                                    cmd2.ExecuteNonQuery();

                                    MessageBox.Show(addEmp_id.Text.Trim() + " employee added!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayEmployeeData();//update table view
                                }
                            }
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Error!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally { 
                    
                    }
                }
            }
        }

        private void addEmp_img_btn_Click(object sender, EventArgs e)
        {

            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
                string imgPath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgPath = openFileDialog.FileName;
                    addEmp_img.ImageLocation = imgPath;
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
