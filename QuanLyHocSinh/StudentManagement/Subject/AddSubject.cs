using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Student;
using System.Data.SqlClient;

namespace StudentManagement.Subject
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TxtDD.Text, out float a))
            {
                if (float.Parse(TxtDD.Text) >= 0 && float.Parse(TxtDD.Text) <=10)
                { 
                    try
                    {
                        SqlConnection connection = ConnectionToSql.getConnection();
                        connection.Open();
                        SqlCommand command = new SqlCommand(@"insert into MONHOC(TENMH, DIEMDAT) VALUES (@TENMH, @DIEMDAT)", connection);
                        command.Parameters.AddWithValue("@TENMH", Convert.ToString(TxtMH.Text));
                        command.Parameters.AddWithValue("@DIEMDAT", float.Parse(TxtDD.Text));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm môn học thành công!");
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        switch (ex.Number)
                        {
                            case 2601:
                                MessageBox.Show("Môn học đã tồn tại trong danh sách môn học!");
                                break;
                            case 110:
                                MessageBox.Show("Điểm đạt phải là 1 số!");
                                break;
                            default:
                                throw;
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Điểm đạt phải trong khoảng 0 tới 10!");
                }
            }
            else
            {
                MessageBox.Show("Điểm đạt phải là 1 số trong khoảng 0 tới 10!");
            }

        }
    }
}
