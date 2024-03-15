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
using StudentManagement.Subject;

namespace StudentManagement.Subject
{
    public partial class CTHForm : Form
    {
        public CTHForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select MACTH,TENMH,TENKHOI,HESO from CHUONGTRINHHOC CTH JOIN KHOI ON CTH.MAKHOI = KHOI.MAKHOI JOIN MONHOC MH ON MH.MAMH = CTH.MAMH ", con);
            DataTable dtCTH = new DataTable();
            sda.Fill(dtCTH);
            DataGridViewCTH.Rows.Clear();
            foreach (DataRow item in dtCTH.Rows)
            {
                int n = DataGridViewCTH.Rows.Add();
                DataGridViewCTH.Rows[n].Cells[0].Value = "false";
                DataGridViewCTH.Rows[n].Cells[1].Value = item["MACTH"].ToString();
                DataGridViewCTH.Rows[n].Cells[2].Value = item["TENMH"].ToString();
                DataGridViewCTH.Rows[n].Cells[3].Value = item["TENKHOI"].ToString();
                DataGridViewCTH.Rows[n].Cells[4].Value = item["HESO"].ToString();
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCTH adf = new AddCTH();
            adf.ShowDialog();
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewCTH.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete From CHUONGTRINHHOC where MACTH ='" + item.Cells[1].Value.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Đã xoá chương trình học thành công...!");
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlCommand command = new SqlCommand("update CHUONGTRINHHOC set HESO = @HESO where MACTH = @MACTH", con);
            command.Parameters.Add("@MACTH", SqlDbType.Int);
            command.Parameters.Add("@HESO", SqlDbType.Float);
            try
            {
                foreach (DataGridViewRow item in DataGridViewCTH.Rows)
                {
                    command.Parameters["@MACTH"].Value = Int32.Parse(item.Cells[1].Value.ToString());
                    command.Parameters["@HESO"].Value = float.Parse(item.Cells[4].Value.ToString());
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2601:
                        MessageBox.Show("Chương trình học đã tồn tại!");
                        break;
                    case 110:
                        MessageBox.Show("Hệ số phải là 1 số!");
                        break;
                    default:
                        throw;
                }
            }
            con.Close();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubjectForm Asf = new SubjectForm();
            Asf.ShowDialog();
        }

        private void DataGridViewCTH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string x;
            switch (DataGridViewCTH.Columns[e.ColumnIndex].Name)
            {
                case "Column40p":
                    x = "a";
                    if (DataGridViewCTH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        x = DataGridViewCTH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    if ((float.TryParse(x, out float a)) == false)
                    {
                        MessageBox.Show("Vui lòng nhập hệ số là một số!");
                    }
                    else
                    {
                        float t = float.Parse(x);
                        if (t < 1 || t > 3)
                        {
                            MessageBox.Show("Vui lòng nhập hệ số là một số trong khoảng 1 tới 3!");
                        }
                    }
                    break;
            }
        }
    }
}
