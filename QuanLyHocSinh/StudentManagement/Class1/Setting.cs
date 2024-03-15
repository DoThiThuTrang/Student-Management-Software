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


namespace StudentManagement
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = ConnectionToSql.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(@"update THAMSO set GIATRI = @maxSiSo where TENTHAMSO = 'SiSoToiDa'", connection);
            command.Parameters.AddWithValue("@maxSiSo", int.Parse(TxtMaxSS.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            connection.Close();
        }
    }
}
