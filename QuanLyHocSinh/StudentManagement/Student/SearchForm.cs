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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            Search();
        }

        private void SearchStudentForm_Load(object sender, EventArgs e)
        {
            SearchMultiRow.AllowUserToAddRows = false;
        }

        private void Search()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            DataTable dtsearch = new DataTable();
            if ((TxtTBI.Text == "TB HK I" || TxtTBI.Text == "") && (TxtTBII.Text == "TB HK II" || TxtTBII.Text == ""))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select distinct TENLOP, HO, TEN, R1.DIEMTB_HOCKY as TBHK1, R2.DIEMTB_HOCKY as TBHK2, HK.NAMHOC "
                + "from QUATRINHHOC QTH join HOCSINH HS on QTH.MAHS = HS.MAHS join HOCKY HK on QTH.MAHK = HK.MAHK join LOP on QTH.MALOP = LOP.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'1') as R1 on QTH.MAHS = R1.MAHS and QTH.MALOP = R1.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'2') as R2 on QTH.MAHS = R2.MAHS and QTH.MALOP = R2.MALOP "
                + "where TENLOP LIKE @LOP and HO LIKE @HO and TEN LIKE @TEN and HK.NAMHOC LIKE @NAMHOC", con);
                if (TxtLop.Text == "Lớp" || TxtLop.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%" + TxtLop.Text + "%";
                }
                if (TxtHo.Text == "Họ" || TxtHo.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%" + TxtHo.Text + "%";
                }
                if (TxtTen.Text == "Tên" || TxtTen.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%" + TxtTen.Text + "%";
                }
                if (TxtNamHoc.Text == "Năm học" || TxtNamHoc.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = TxtNamHoc.Text;
                }
                sda.Fill(dtsearch);
            }
            else if ((TxtTBI.Text != "TB HK I" && TxtTBI.Text != "") && (TxtTBII.Text == "TB HK II" || TxtTBII.Text == ""))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select distinct TENLOP, HO, TEN, R1.DIEMTB_HOCKY as TBHK1, R2.DIEMTB_HOCKY as TBHK2, HK.NAMHOC "
                + "from QUATRINHHOC QTH join HOCSINH HS on QTH.MAHS = HS.MAHS join HOCKY HK on QTH.MAHK = HK.MAHK join LOP on QTH.MALOP = LOP.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'1') as R1 on QTH.MAHS = R1.MAHS and QTH.MALOP = R1.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'2') as R2 on QTH.MAHS = R2.MAHS and QTH.MALOP = R2.MALOP "
                + "where TENLOP LIKE @LOP and HO LIKE @HO and TEN LIKE @TEN and R1.DIEMTB_HOCKY = @TB1 and HK.NAMHOC LIKE @NAMHOC", con);
                if (TxtLop.Text == "Lớp" || TxtLop.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%" + TxtLop.Text + "%";
                }
                if (TxtHo.Text == "Họ" || TxtHo.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%" + TxtHo.Text + "%";
                }
                if (TxtTen.Text == "Tên" || TxtTen.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%" + TxtTen.Text + "%";
                }
                sda.SelectCommand.Parameters.Add("@TB1", SqlDbType.NVarChar, 4).Value = (TxtTBI.Text.ToString());
                if (TxtNamHoc.Text == "Năm học" || TxtNamHoc.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = TxtNamHoc.Text;
                }
                sda.Fill(dtsearch);
            }
            else if ((TxtTBII.Text != "TB HK II" && TxtTBII.Text != "") && (TxtTBI.Text == "TB HK I" || TxtTBI.Text == ""))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select distinct TENLOP, HO, TEN, R1.DIEMTB_HOCKY as TBHK1, R2.DIEMTB_HOCKY as TBHK2, HK.NAMHOC "
                + "from QUATRINHHOC QTH join HOCSINH HS on QTH.MAHS = HS.MAHS join HOCKY HK on QTH.MAHK = HK.MAHK join LOP on QTH.MALOP = LOP.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'1') as R1 on QTH.MAHS = R1.MAHS and QTH.MALOP = R1.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'2') as R2 on QTH.MAHS = R2.MAHS and QTH.MALOP = R2.MALOP "
                + "where TENLOP LIKE @LOP and HO LIKE @HO and TEN LIKE @TEN and R2.DIEMTB_HOCKY = @TB2 and HK.NAMHOC LIKE @NAMHOC", con);
                if (TxtLop.Text == "Lớp" || TxtLop.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%" + TxtLop.Text + "%";
                }
                if (TxtHo.Text == "Họ" || TxtHo.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%" + TxtHo.Text + "%";
                }
                if (TxtTen.Text == "Tên" || TxtTen.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%" + TxtTen.Text + "%";
                }
                sda.SelectCommand.Parameters.Add("@TB2", SqlDbType.NVarChar, 4).Value = (TxtTBII.Text.ToString());
                if (TxtNamHoc.Text == "Năm học" || TxtNamHoc.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = TxtNamHoc.Text;
                }
                sda.Fill(dtsearch);
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select distinct TENLOP, HO, TEN, R1.DIEMTB_HOCKY as TBHK1, R2.DIEMTB_HOCKY as TBHK2, HK.NAMHOC "
                + "from QUATRINHHOC QTH join HOCSINH HS on QTH.MAHS = HS.MAHS join HOCKY HK on QTH.MAHK = HK.MAHK join LOP on QTH.MALOP = LOP.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'1') as R1 on QTH.MAHS = R1.MAHS and QTH.MALOP = R1.MALOP left join "
                + "(select QTH1.MAHS, QTH1.MALOP, QTH1.DIEMTB_HOCKY from QUATRINHHOC QTH1 join HOCKY HK1 on QTH1.MAHK = HK1.MAHK where HK1.TENHOCKY = N'2') as R2 on QTH.MAHS = R2.MAHS and QTH.MALOP = R2.MALOP "
                + "where TENLOP LIKE @LOP and HO LIKE @HO and TEN LIKE @TEN and R1.DIEMTB_HOCKY = @TB1 and R2.DIEMTB_HOCKY = @TB2 and HK.NAMHOC LIKE @NAMHOC", con);
                if (TxtLop.Text == "Lớp" || TxtLop.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@LOP", SqlDbType.NVarChar, 100).Value = "%" + TxtLop.Text + "%";
                }
                if (TxtHo.Text == "Họ" || TxtHo.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 40).Value = "%" + TxtHo.Text + "%";
                }
                if (TxtTen.Text == "Tên" || TxtTen.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 10).Value = "%" + TxtTen.Text + "%";
                }
                sda.SelectCommand.Parameters.Add("@TB1", SqlDbType.NVarChar, 4).Value = (TxtTBI.Text.ToString());
                sda.SelectCommand.Parameters.Add("@TB2", SqlDbType.NVarChar, 4).Value = (TxtTBII.Text.ToString());
                if (TxtNamHoc.Text == "Năm học" || TxtNamHoc.Text == "")
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = "%";
                }
                else
                {
                    sda.SelectCommand.Parameters.Add("@NAMHOC", SqlDbType.NVarChar, 10).Value = TxtNamHoc.Text;
                }
                sda.Fill(dtsearch);
            }
            SearchMultiRow.Rows.Clear();
            foreach (DataRow item in dtsearch.Rows)
            {
                int n = SearchMultiRow.Rows.Add();
                SearchMultiRow.Rows[n].Cells[0].Value = item["TENLOP"].ToString();
                SearchMultiRow.Rows[n].Cells[1].Value = item["HO"].ToString();
                SearchMultiRow.Rows[n].Cells[2].Value = item["TEN"].ToString();
                SearchMultiRow.Rows[n].Cells[3].Value = item["TBHK1"].ToString();
                SearchMultiRow.Rows[n].Cells[4].Value = item["TBHK2"].ToString();
                SearchMultiRow.Rows[n].Cells[5].Value = item["NAMHOC"].ToString();
            }
          
            con.Close();
        }

        private void TxtHo_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtHo_Enter(object sender, EventArgs e)
        {
            if (TxtHo.Text.Equals(@"Họ"))
            {
                TxtHo.Text = "";
            }
        }

        private void TxtHo_Leave(object sender, EventArgs e)
        {
            if (TxtHo.Text.Equals(""))
            {
                TxtHo.Text = @"Họ";
            }
        }

        private void TxtTen_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtTen_Enter(object sender, EventArgs e)
        {
            if (TxtTen.Text.Equals(@"Tên"))
            {
                TxtTen.Text = "";
            }
        }

        private void TxtTen_Leave(object sender, EventArgs e)
        {
            if (TxtTen.Text.Equals(""))
            {
                TxtTen.Text = @"Tên";
            }
        }

        private void TxtLop_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtLop_Enter(object sender, EventArgs e)
        {
            if (TxtLop.Text.Equals(@"Lớp"))
            {
                TxtLop.Text = "";
            }
        }

        private void TxtLop_Leave(object sender, EventArgs e)
        {
            if (TxtLop.Text.Equals(""))
            {
                TxtLop.Text = @"Lớp";
            }
        }

        private void TxtTBI_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtTBI_Enter(object sender, EventArgs e)
        {
            if (TxtTBI.Text.Equals(@"TB HK I"))
            {
                TxtTBI.Text = "";
            }
        }

        private void TxtTBI_Leave(object sender, EventArgs e)
        {
            if (TxtTBI.Text.Equals(""))
            {
                TxtTBI.Text = @"TB HK I";
            }
        }

        private void TxtTBII_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtTBII_Enter(object sender, EventArgs e)
        {
            if (TxtTBII.Text.Equals(@"TB HK II"))
            {
                TxtTBII.Text = "";
            }
        }

        private void TxtTBII_Leave(object sender, EventArgs e)
        {
            if (TxtTBII.Text.Equals(""))
            {
                TxtTBII.Text = @"TB HK II";
            }
        }

        private void TxtNamHoc_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtNamHoc_Enter(object sender, EventArgs e)
        {
            if (TxtNamHoc.Text.Equals(@"Năm học"))
            {
                TxtNamHoc.Text = "";
            }
        }

        private void TxtNamHoc_Leave(object sender, EventArgs e)
        {
            if (TxtNamHoc.Text.Equals(""))
            {
                TxtNamHoc.Text = @"Năm học";
            }
        }
    }
       
}
