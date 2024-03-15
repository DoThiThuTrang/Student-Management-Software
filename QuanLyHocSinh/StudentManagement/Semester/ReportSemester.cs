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

namespace StudentManagement.Semester
{
    public partial class ReportSemester : Form
    {
        public ReportSemester()
        {
            InitializeComponent();
        }

        private void ReportSemester_Load(object sender, EventArgs e)
        {
            using (QLHSEntities2 db = new QLHSEntities2())
            {
                cbBoxHK.DataSource = db.HOCKies.ToList();
                cbBoxHK.ValueMember = "MAHK";
                cbBoxHK.DisplayMember = "HOCKY1";
            }
            CalculateTBHK();
            LoadDataReport1();
        }

        public void CalculateTBHK()
        {
            var con1 = ConnectToSqlSemester.getConnection();
            con1.Open();
            SqlCommand command1 = new SqlCommand("UPDATE QUATRINHHOC  "
                   + "SET DIEMTB_HOCKY = ROUND((SELECT SUM(BDM.DIEMTRUNGBINHMON*CTH.HESO) FROM BANGDIEMMON BDM, CHUONGTRINHHOC CTH , LOP L "
                   + "WHERE QUATRINHHOC.MAQTH = BDM.MAQTH AND QUATRINHHOC.MALOP = L.MALOP AND L.MAKHOI = CTH.MAKHOI AND BDM.MAMH = CTH.MAMH) "
                   + "/ (SELECT SUM(CTH.HESO) FROM BANGDIEMMON BDM, CHUONGTRINHHOC CTH , LOP L "
                   + "WHERE QUATRINHHOC.MAQTH = BDM.MAQTH AND QUATRINHHOC.MALOP = L.MALOP AND L.MAKHOI = CTH.MAKHOI AND BDM.MAMH = CTH.MAMH),2) ", con1);
            HOCKY objHK = cbBoxHK.SelectedItem as HOCKY;
            command1.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
            command1.ExecuteNonQuery();
            con1.Close();
        }
        public void LoadDataReport1()
        {
            var con = ConnectToSqlSemester.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select TENLOP,TK.SISO, SOLUONGDAT, CONCAT(TILE , '%') as TILE from HOCKY HK join TONGKETHOCKY TK on HK.MAHK = TK.MAHK join LOP L on TK.MALOP = L.MALOP where HK.MAHK = @MAHK", con);
            DataTable dtSemester = new DataTable();
            HOCKY objHK = cbBoxHK.SelectedItem as HOCKY;
            sda.SelectCommand.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
            sda.Fill(dtSemester);
            if (dtSemester.Rows.Count <= 0)
            {
                SqlCommand command2 = new SqlCommand("insert into TONGKETHOCKY(MALOP,MAHK,SISO,SOLUONGDAT,TILE)    "
                       + "select R1.MALOP, R1.MAHK, R2.SISO,R1.SLDAT, CAST(ROUND(R1.SLDAT*100.0/R2.SISO,2) as numeric(5,2)) as TLDAT "
                       + "from (select L.MALOP,L.TENLOP, HK.MAHK, count(*) as SLDAT from QUATRINHHOC QT join LOP L on QT.MALOP = L.MALOP join HOCKY HK on QT.MAHK = HK.MAHK, THAMSO TS  "
                       + "where HK.MAHK = @MAHK and DIEMTB_HOCKY >= TS.GIATRI and TS.TENTHAMSO = 'DiemDatHocKy' group by L.MALOP,L.TENLOP, HK.MAHK) as R1 join (select L.MALOP, HK.MAHK, count(*) as SISO "
                       + "from QUATRINHHOC QT join LOP L on QT.MALOP = L.MALOP join HOCKY HK on QT.MAHK = HK.MAHK where HK.MAHK = @MAHK group by L.MALOP, HK.MAHK) as R2 on R1.MALOP = R2.MALOP and R1.MAHK = R2.MAHK ", con);
                command2.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
                command2.ExecuteNonQuery();
                MessageBox.Show("Đang tính toán báo cáo thống kê tổng kết học kỳ");
                SqlDataAdapter sda1 = new SqlDataAdapter("Select TENLOP,TK.SISO, SOLUONGDAT, CONCAT(TILE , '%') as TILE from HOCKY HK join TONGKETHOCKY TK on HK.MAHK = TK.MAHK join LOP L on TK.MALOP = L.MALOP where HK.MAHK = @MAHK", con);
                sda1.SelectCommand.Parameters.Add("@MAHK", SqlDbType.Int).Value = objHK.MAHK;
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

        private void cbBoxHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataReport1();
            Cursor.Current = Cursors.Default;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting ac = new Setting();
            ac.ShowDialog();
        }
    }
}
