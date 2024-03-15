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

namespace StudentManagement.Class1
{
    public partial class ClassForm1 : Form
    {
        public ClassForm1()
        {
            InitializeComponent();
            UpdateSS();
            LoadDataClass();
        }

        public void UpdateSS()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlCommand command1 = new SqlCommand("update LOP set SISO = (select count(*) from QUATRINHHOC QTH " +
                "where MAHK = (Select TOP 1 MAHK  from HOCKY order by Cast(((Cast(NAMHOC as nvarchar) +Cast(TENHOCKY as nvarchar))) as int) desc ) and MALOP = LOP.MALOP) ", con);
            command1.ExecuteNonQuery();
            con.Close();
        }
        public void LoadDataClass()
        {
            var connect = ConnectionToSql.getConnection();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select MALOP, TENLOP, SISO,TENKHOI, KHOI.MAKHOI from LOP join KHOI on LOP.MAKHOI = KHOI.MAKHOI order by KHOI.MAKHOI", connect);
            DataTable dtClass = new DataTable();
            adapter.Fill(dtClass);
            DataGridViewClass.Rows.Clear();
            foreach (DataRow item in dtClass.Rows)
            {
                int n = DataGridViewClass.Rows.Add();
                DataGridViewClass.Rows[n].Cells[0].Value = "false";
                DataGridViewClass.Rows[n].Cells[1].Value = item["MALOP"].ToString();
                DataGridViewClass.Rows[n].Cells[2].Value = item["TENLOP"].ToString();
                DataGridViewClass.Rows[n].Cells[3].Value = item["SISO"].ToString();
                DataGridViewClass.Rows[n].Cells[4].Value = item["TENKHOI"].ToString();
            }
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClass ac = new AddClass();
            ac.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewClass.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete From LOP where MALOP ='" + item.Cells[1].Value.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Đã xoá lớp thành công ...!");
            LoadDataClass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlCommand command = new SqlCommand("update LOP set TENLOP = @TENLOP, MAKHOI = ( select MAKHOI from KHOI where TENKHOI = @TENKHOI) where MALOP = @MALOP ", con);
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@TENKHOI", SqlDbType.NVarChar,40);
            command.Parameters.Add("@MALOP", SqlDbType.Int);
            foreach (DataGridViewRow item in DataGridViewClass.Rows)
            {
                command.Parameters["@TENLOP"].Value = Convert.ToString(item.Cells[2].Value);
                command.Parameters["@TENKHOI"].Value = Convert.ToString(item.Cells[4].Value);
                command.Parameters["@MALOP"].Value = Convert.ToInt32(item.Cells[1].Value);
                command.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Cập nhật thành công...!");
            LoadDataClass();
        }

        private void DataGridViewClass_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (DataGridViewClass.Columns[e.ColumnIndex].Name)
            {
                case "Column4":
                    string x = "a";
                    if (DataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        x = DataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        if (x != "10" && x != "11" && x != "12")
                        {
                            MessageBox.Show("Chỉ nhập các khối có sẵn (10, 11, 12)");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập vào một khối");
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentToClass ac = new AddStudentToClass();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInClass ac = new StudentInClass();
            ac.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting ac = new Setting();
            ac.ShowDialog();
        }
    }
    
}
