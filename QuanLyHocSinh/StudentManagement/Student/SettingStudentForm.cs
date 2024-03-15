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
using StudentManagement.Student;

namespace StudentManagement.Student
{
    public partial class SettingStudentForm : Form
    {
        public SettingStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = ConnectionToSql.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(@"update THAMSO set GIATRI = @minAge where TENTHAMSO = 'TuoiToiThieu'", connection);
            command.Parameters.AddWithValue("@minAge", int.Parse(TxtMinAge.Text));
            command.ExecuteNonQuery();
            SqlCommand command1 = new SqlCommand(@"update THAMSO set GIATRI = @maxAge where TENTHAMSO = 'TuoiToiDa'", connection);
            command1.Parameters.AddWithValue("@maxAge", int.Parse(TxtMaxAge.Text));
            command1.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            connection.Close();
        }
    }
}
