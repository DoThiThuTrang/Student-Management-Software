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
    public partial class AddStudentToClass : Form
    {
        public AddStudentToClass()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select HS.MAHS,HO,TEN,NGSINH,GIOITINH,DIACHI,EMAIL from HOCSINH HS left join (select * from QUATRINHHOC where MAHK = '1003') as QT on HS.MAHS = QT.MAHS where QT.MALOP is NULL order by HS.MAHS", con);
            DataTable dtStudent = new DataTable();
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

        private void AddStudentToClass_Load(object sender, EventArgs e)
        {
            using (QLHSEntities2 db = new QLHSEntities2())
            {
                cbBoxLop.DataSource = db.LOPs.ToList();
                cbBoxLop.ValueMember = "MALOP";
                cbBoxLop.DisplayMember = "TENLOP";
            }
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LOP objLop = cbBoxLop.SelectedItem as LOP;
            QTHDetail detailModel = new QTHDetail();
            List<QTHDetail> objectDetailList = new List<QTHDetail>();
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewStudent.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    var detail = new QTHDetail()
                    {

                        MAHS = Int32.Parse(item.Cells[1].Value.ToString()),
                        MALOP = objLop.MALOP,
                    };
                    objectDetailList.Add(detail);
                }
            }
            detailModel = new QTHDetail();
            var con1 = ConnectionToSql.getConnection();
            con1.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) as SS from QUATRINHHOC QTH where MAHK = (Select TOP 1 MAHK  from HOCKY order by Cast(((Cast(NAMHOC as nvarchar) + Cast(TENHOCKY as nvarchar))) as int) desc) and MALOP = @MALOP", con);
            sda.SelectCommand.Parameters.Add("@MALOP", SqlDbType.Int).Value = objLop.MALOP;
            DataTable dtSS = new DataTable();
            sda.Fill(dtSS);
            int siso = dtSS.Rows[0].Field<int>("SS");
            SqlDataAdapter sda1 = new SqlDataAdapter("select CAST(GIATRI as int) as SSTD from THAMSO where TENTHAMSO = 'SiSoToiDa'", con);
            DataTable dtSSTD = new DataTable();
            sda1.Fill(dtSSTD);
            int sisotoida = dtSSTD.Rows[0].Field<int>("SSTD");
            if (siso + objectDetailList.Count > sisotoida)
            {
                MessageBox.Show("Sĩ số tôi đa là " + sisotoida.ToString() + ". Bạn chỉ được thêm thêm " + (sisotoida - siso).ToString() + " học sinh vào lớp này!");
            }
            else
            {
                detailModel.add_MultipleStatementsSingleInsert(objectDetailList);
                LoadData();
            }
        }
        
    }
}
