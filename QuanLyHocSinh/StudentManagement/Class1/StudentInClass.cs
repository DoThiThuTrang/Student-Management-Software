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
    public partial class StudentInClass : Form
    {
        public StudentInClass()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select HS.MAHS,HO,TEN,NGSINH,GIOITINH,DIACHI,EMAIL from HOCSINH HS left join QUATRINHHOC QT on HS.MAHS = QT.MAHS where QT.MALOP = @MALOP and QT.MAHK = (Select TOP 1 MAHK  from HOCKY order by Cast(((Cast(NAMHOC as nvarchar) + Cast(TENHOCKY as nvarchar))) as int) desc) order by MAHS", con);
            DataTable dtStudent = new DataTable();
            LOP objLop = cbBoxLop.SelectedItem as LOP;
            sda.SelectCommand.Parameters.Add("@MALOP", SqlDbType.Int).Value = objLop.MALOP;
            sda.Fill(dtStudent);
            DataGridViewStudent.Rows.Clear();
            foreach (DataRow item in dtStudent.Rows)
            {
                int n = DataGridViewStudent.Rows.Add();
                DataGridViewStudent.Rows[n].Cells[0].Value = "false";
                DataGridViewStudent.Rows[n].Cells[1].Value = item["MAHS"].ToString();
                DataGridViewStudent.Rows[n].Cells[2].Value = item["HO"].ToString();
                DataGridViewStudent.Rows[n].Cells[3].Value = item["TEN"].ToString();
                DataGridViewStudent.Rows[n].Cells[4].Value = item["NGSINH"].ToString();
                DataGridViewStudent.Rows[n].Cells[5].Value = item["GIOITINH"].ToString();
                DataGridViewStudent.Rows[n].Cells[6].Value = item["DIACHI"].ToString();
                DataGridViewStudent.Rows[n].Cells[7].Value = item["EMAIL"].ToString();
            }
            con.Close();
        }

        private void StudentInClass_Load(object sender, EventArgs e)
        {
            using (QLHSEntities2 db = new QLHSEntities2())
            {
                cbBoxLop.DataSource = db.LOPs.ToList();
                cbBoxLop.ValueMember = "MALOP";
                cbBoxLop.DisplayMember = "TENLOP";
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LOP objLop = cbBoxLop.SelectedItem as LOP;
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewStudent.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete From QUATRINHHOC where MALOP = @MALOP and MAHS = @MAHS and MAHK = (Select TOP 1 MAHK  from HOCKY order by Cast(((Cast(NAMHOC as nvarchar) + Cast(TENHOCKY as nvarchar))) as int) desc)", con);
                    command.Parameters.Add("@MALOP", SqlDbType.Int, 40);
                    command.Parameters.Add("@MAHS", SqlDbType.NVarChar, 40);
                    command.Parameters["@MALOP"].Value = objLop.MALOP;
                    command.Parameters["@MAHS"].Value = Convert.ToString(item.Cells[1].Value);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Đã xoá lớp thành công ...!");
            LoadData();
        }

        private void cbBoxLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
