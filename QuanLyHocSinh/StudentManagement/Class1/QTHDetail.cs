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
    class QTHDetail
    {
        public int MALOP { get; set; }
        public int MAHS { get; set; }
        public int MaxSiSo()
        {
            var maxSS = 40;
            SqlConnection connection = ConnectionToSql.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select GIATRI from THAMSO where TENTHAMSO = 'SiSoToiDa'", connection);
            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                maxSS = Convert.ToInt32(da.GetValue(0).ToString());
            }
            return maxSS;
        }
        public void add_MultipleStatementsSingleInsert(IEnumerable<QTHDetail> entities)
        {
            using (var connection = ConnectionToSql.getConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "Insert into QUATRINHHOC(MALOP,MAHS,MAHK) values (@MALOP,@MAHS, (Select TOP 1 MAHK  from HOCKY  "
                                                + "order by Cast(((Cast(NAMHOC as nvarchar) + Cast(TENHOCKY as nvarchar))) as int) desc))";
                        command.Parameters.Add("@MALOP", SqlDbType.Int);
                        command.Parameters.Add("@MAHS", SqlDbType.Int);
                        try
                        {
                            foreach (var item in entities)
                            {
                                command.Parameters["@MALOP"].Value = item.MALOP;
                                command.Parameters["@MAHS"].Value = item.MAHS;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Thêm học sinh vào lớp thành công!");
                            SqlCommand command1 = new SqlCommand("insert into BANGDIEMMON(MAMH,MAQTH) (select MAMH, QTH.MAQTH from MONHOC MH, (select QTH.MAQTH from QUATRINHHOC QTH left join BANGDIEMMON BDM on QTH.MAQTH = BDM.MAQTH where BDM.MAMH is NULL) as QTH)", connection);
                            command1.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            connection.Close();
                            throw;
                        }
                    }
                }
                
            }
        }
    }
}
