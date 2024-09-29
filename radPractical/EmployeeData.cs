using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;


namespace radPractical
{
    internal class EmployeeData
    {
        public int Id { set; get; }
        public string EmpId { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Contact { set; get; }
        public string Position { set; get; }
        public string Img { set; get; }
        public int Salary { set; get; }
        public string Status { set; get; }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public List<EmployeeData> employeeListData() { 
            List<EmployeeData> listData = new List<EmployeeData>();

            if (conn.State != ConnectionState.Open) {

                try { 
                    conn.Open();
                    string selectData = "select * from employee where delete_date is null";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn)) { 
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeData empd = new EmployeeData();
                            empd.Id = (int)reader["id"];
                            empd.EmpId = reader["employee_id"].ToString();
                            empd.Name = reader["full_name"].ToString();
                            empd.Gender = reader["gender"].ToString();
                            empd.Contact = reader["tele_no"].ToString();
                            empd.Position = reader["position"].ToString();
                            empd.Img = reader["image"].ToString();
                            //empd.Salary = (int)reader["salary"];
                            empd.Status = reader["ststus"].ToString();

                            listData.Add(empd);
                        }
                    }


                }
                catch (Exception ex) {
                    MessageBox.Show("Error!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                }
            }
            return listData;
        }
        }
    }

