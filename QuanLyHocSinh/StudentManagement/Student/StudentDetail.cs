using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.Student
{
    public class StudentDetail
    {
        public string HO { get; set; }
        public string TEN { get; set; }
        public DateTime NGSINH { get; set; }
        public string GIOITINH { get; set; }

        public string DIACHI { get; set; }

        public string EMAIL { get; set; }

        public int MinAge()
        {
            var minAge = 15;
            SqlConnection connection = ConnectionToSql.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select GIATRI from THAMSO where TENTHAMSO = 'TuoiToiThieu'", connection);
            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                minAge = Convert.ToInt32(da.GetValue(0).ToString());
            }
            return minAge;
        }
        public int MaxAge()
        {
            var maxAge = 20;
            SqlConnection connection = ConnectionToSql.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select GIATRI from THAMSO where TENTHAMSO = 'TuoiToiDa'", connection);
            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                maxAge = Convert.ToInt32(da.GetValue(0).ToString());
            }
            return maxAge;
        }

        public void add_MultipleStatementsSingleInsert(IEnumerable<StudentDetail> entities)
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
                        command.CommandText = "insert into HOCSINH(HO,TEN,NGSINH,GIOITINH,DIACHI,EMAIL) values (@HO,@TEN,@NGSINH,@GIOITINH,@DIACHI,@EMAIL)";
                        command.Parameters.Add("@HO", SqlDbType.NVarChar, 40);
                        command.Parameters.Add("@TEN", SqlDbType.NVarChar, 10);
                        command.Parameters.Add("@NGSINH", SqlDbType.Date);
                        command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 3);
                        command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 40);
                        command.Parameters.Add("@EMAIL", SqlDbType.VarChar, 30);
                        try
                        {
                            foreach (var item in entities)
                            {
                                command.Parameters["@HO"].Value = item.HO;
                                command.Parameters["@TEN"].Value = item.TEN;
                                command.Parameters["@NGSINH"].Value = item.NGSINH;
                                command.Parameters["@GIOITINH"].Value = item.GIOITINH;
                                command.Parameters["@DIACHI"].Value = item.DIACHI;
                                command.Parameters["@EMAIL"].Value = item.EMAIL;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
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
