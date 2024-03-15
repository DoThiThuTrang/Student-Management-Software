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

namespace StudentManagement.Subject
{
    public partial class AddCTH : Form
    {
        public AddCTH()
        {
            InitializeComponent();
        }
        private void AddCTH_Load(object sender, EventArgs e)
        {
            using (QLHSEntities2 db = new QLHSEntities2())
            {
                cbBoxMH.DataSource = db.MONHOCs.ToList();
                cbBoxMH.ValueMember = "MAMH";
                cbBoxMH.DisplayMember = "TENMH";
                cbBoxKhoi.DataSource = db.KHOIs.ToList();
                cbBoxKhoi.ValueMember = "MAKHOI";
                cbBoxKhoi.DisplayMember = "TENKHOI";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TxtHS.Text, out float a))
            {
                if (float.Parse(TxtHS.Text) >= 1 && float.Parse(TxtHS.Text) <= 3)
                {
                    try
                    {
                        SqlConnection connection = ConnectionToSql.getConnection();
                        connection.Open();
                        SqlCommand command = new SqlCommand(@"insert into CHUONGTRINHHOC(MAMH, MAKHOI, HESO) VALUES (@MAMH, @MAKHOI, @HESO)", connection);
                        MONHOC objMH = cbBoxMH.SelectedItem as MONHOC;
                        command.Parameters.AddWithValue("@MAMH", objMH.MAMH);
                        KHOI objK = cbBoxKhoi.SelectedItem as KHOI;
                        command.Parameters.AddWithValue("@MAKHOI", objK.MAKHOI);
                        command.Parameters.AddWithValue("@HESO", float.Parse(TxtHS.Text));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm chương trình học thành công!");
                        connection.Close();
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
                }
                else
                {
                    MessageBox.Show("Hệ số phải trong khoảng 0 tới 10!");
                }
            }
            else
            {
                MessageBox.Show("Hệ số phải là 1 số trong khoảng 1 tới 3!");
            }

        }
    }
    
}
