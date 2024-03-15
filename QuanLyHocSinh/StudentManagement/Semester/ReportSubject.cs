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
using StudentManagement.Semester;


namespace StudentManagement.Semester
{
    public partial class ReportSubject : Form
    {
        public ReportSubject()
        {
            InitializeComponent();
        }
        
        private void Semester_Load(object sender, EventArgs e)
        {
            using (QLHSEntities2 db = new QLHSEntities2())
            {
                cbBoxMonHoc.DataSource = db.MONHOCs.ToList();
                cbBoxMonHoc.ValueMember = "MAMH";
                cbBoxMonHoc.DisplayMember = "TENMH";
                cbBoxHK.DataSource = db.HOCKies.ToList();
                cbBoxHK.ValueMember = "MAHK";
                cbBoxHK.DisplayMember = "HOCKY1";
            }
            LoadDataReport();
        }

        public void LoadDataReport()
        {

            var con = ConnectToSqlSemester.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select TENLOP,TK.SISO, SOLUONGDAT, CONCAT(TILE , '%') as TILE from HOCKY HK join TONGKETMON TK on HK.MAHK = TK.MAHK join LOP L on TK.MALOP = L.MALOP where HK.MAHK = @MAHK and TK.MAMH = @MAMH", con);
            DataTable dtSemester = new DataTable();
            HOCKY objHK = cbBoxHK.SelectedItem as HOCKY;
            sda.SelectCommand.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
            MONHOC objMH = cbBoxMonHoc.SelectedItem as MONHOC;
            sda.SelectCommand.Parameters.Add("@MAMH", SqlDbType.Int).Value = objMH.MAMH;
            sda.Fill(dtSemester);
            if (dtSemester.Rows.Count <= 0)
            {
                DataTable dtTKBCM = new DataTable();
                SqlCommand command1 = new SqlCommand("insert into TONGKETMON(MALOP,MAMH,MAHK,SOLUONGDAT,TILE) select R1.MALOP, R1.MAMH, R1.MAHK, R1.SLDAT, CAST(ROUND(R1.SLDAT*100.0/R2.SISO,2) as numeric(5,2)) as TLDAT "
                       + "from (select L.MALOP, L.TENLOP, HK.MAHK, MH.MAMH, count(*) as SLDAT from QUATRINHHOC QT join LOP L on QT.MALOP = L.MALOP join HOCKY HK on QT.MAHK = HK.MAHK join BANGDIEMMON BD on BD.MAQTH = QT.MAQTH join MONHOC MH on BD.MAMH = MH.MAMH "
                       + "where MH.MAMH = @MAMH and HK.MAHK = @MAHK and DIEMTRUNGBINHMON >= DIEMDAT group by L.MALOP, L.TENLOP, HK.MAHK, MH.MAMH) as R1 join (select L.MALOP, HK.MAHK, MH.MAMH, count(*) as SISO "
                       + "from QUATRINHHOC QT join LOP L on QT.MALOP = L.MALOP join HOCKY HK on QT.MAHK = HK.MAHK join BANGDIEMMON BD on BD.MAQTH = QT.MAQTH join MONHOC MH on BD.MAMH = MH.MAMH where MH.MAMH = @MAMH and HK.MAHK = @MAHK  "
                       + "group by L.MALOP, HK.MAHK, MH.MAMH) as R2 on R1.MALOP = R2.MALOP and R1.MAHK = R2.MAHK and R1.MAMH = R2.MAMH ", con);
                command1.Parameters.Add("@MAMH", SqlDbType.Int).Value = objMH.MAMH;
                command1.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
                command1.ExecuteNonQuery();
                MessageBox.Show("Đang tính toán báo cáo thống kê tổng kết môn học");
                SqlDataAdapter sda1 = new SqlDataAdapter("Select TENLOP,TK.SISO, SOLUONGDAT, CONCAT(TILE , '%') as TILE from HOCKY HK join TONGKETMON TK on HK.MAHK = TK.MAHK join LOP L on TK.MALOP = L.MALOP where HK.MAHK = @MAHK and TK.MAMH = @MAMH", con);
                sda1.SelectCommand.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
                sda1.SelectCommand.Parameters.Add("@MAMH", SqlDbType.Int).Value = objMH.MAMH;
                sda1.Fill(dtSemester);
            }
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dtSemester.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["TENLOP"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["SISO"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["SOLUONGDAT"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["TILE"].ToString();
            }
            con.Close();
        }

        private void cbBoxMonHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataReport();
            Cursor.Current = Cursors.Default;
        }

        private void cbBoxHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataReport();
            Cursor.Current = Cursors.Default;
        }
    }
}
