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
using StudentManagement.Subject;

namespace StudentManagement.Subject
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select MAMH,TENMH,DIEMDAT from MONHOC", con);
            DataTable dtCTH = new DataTable();
            sda.Fill(dtCTH);
            DataGridViewSubject.Rows.Clear();
            foreach (DataRow item in dtCTH.Rows)
            {
                int n = DataGridViewSubject.Rows.Add();
                DataGridViewSubject.Rows[n].Cells[0].Value = "false";
                DataGridViewSubject.Rows[n].Cells[1].Value = item["MAMH"].ToString();
                DataGridViewSubject.Rows[n].Cells[2].Value = item["TENMH"].ToString();
                DataGridViewSubject.Rows[n].Cells[3].Value = item["DIEMDAT"].ToString();
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSubject Asf = new AddSubject();
            Asf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlCommand command = new SqlCommand("update MONHOC set TENMH = @TENMH, DIEMDAT = @DIEMDAT where MAMH = @MAMH", con);
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MAMH", SqlDbType.Int);
            command.Parameters.Add("@DIEMDAT", SqlDbType.Int);
            try
            {
                foreach (DataGridViewRow item in DataGridViewSubject.Rows)
                {
                    command.Parameters["@MAMH"].Value = Int32.Parse(item.Cells[1].Value.ToString());
                    command.Parameters["@TENMH"].Value = Convert.ToString(item.Cells[2].Value);
                    command.Parameters["@DIEMDAT"].Value = float.Parse(item.Cells[3].Value.ToString());
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thành công!");
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
            con.Close();
            LoadData();
        }

        private void DataGridViewSubject_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string x;
            switch (DataGridViewSubject.Columns[e.ColumnIndex].Name)
            {
                case "Column3":
                    x = "a";
                    if (DataGridViewSubject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        x = DataGridViewSubject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    if ((float.TryParse(x, out float a)) == false)
                    {
                        MessageBox.Show("Vui lòng nhập điểm đạt là một số!");
                    }
                    else
                    {
                        float t = float.Parse(x);
                        if (t < 0 || t > 10)
                        {
                            MessageBox.Show("Vui lòng nhập điểm đạt là một số trong khoảng 0 tới 10!");
                        }
                    }
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewSubject.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete From MONHOC where MAMH ='" + item.Cells[1].Value.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Đã xoá môn học thành công...!");
            LoadData();
        }

    }
}
