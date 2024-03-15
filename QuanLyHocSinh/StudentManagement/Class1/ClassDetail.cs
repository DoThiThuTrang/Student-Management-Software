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
    class ClassDetail
    {
        // public int MALOP { get; set; }
        public string MAKHOI { get; set; }
        public string TENLOP { get; set; }
        public int MaxSiSo()
        {
            var maxAge = 40;
            SqlConnection connection = ConnectionToSql.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select GIATRI from THAMSO where TENTHAMSO = 'SiSoToiDa'", connection);
            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                maxAge = Convert.ToInt32(da.GetValue(0).ToString());
            }
            return maxAge;
        }
        public void add_MultipleStatementsSingleInsert(IEnumerable<ClassDetail> entities)
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
                        command.CommandText = "insert into LOP(TENLOP,MAKHOI) values (@TENLOP,@MAKHOI)";
                        command.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 40);           
                        command.Parameters.Add("@MAKHOI", SqlDbType.NVarChar,40);
                        try
                        {
                            foreach (var item in entities)
                            {
                                command.Parameters["@TENLOP"].Value = item.TENLOP;
                                command.Parameters["@MAKHOI"].Value = item.MAKHOI;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Thêm lớp học thành công!");
                        }
                        catch (SqlException ex )
                        {
                            transaction.Rollback();
                            switch (ex.Number)
                            {
                                case 2601:
                                    MessageBox.Show("Lớp học đã tồn tại!");
                                    break;
                                default:
                                    throw;
                            }
                            
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
