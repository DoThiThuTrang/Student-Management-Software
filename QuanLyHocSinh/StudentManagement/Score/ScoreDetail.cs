using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.Student
{
    public class ScoreDetail
    {
        public int MABDM { get; set; }
        public int MALHKT { get; set; }
        public float DIEM { get; set; }

        public void add_MultipleScoresSingleInsert(IEnumerable<ScoreDetail> entities)
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
                        command.CommandText = "insert into CT_BANGDIEMMON(MABDM, MALHKT, DIEM) values (@MABDM, @MALHKT, @DIEM)";
                        command.Parameters.Add("@MABDM", SqlDbType.Int);
                        command.Parameters.Add("@MALHKT", SqlDbType.Int);
                        command.Parameters.Add("@DIEM", SqlDbType.Float);
                        try
                        {
                            foreach (var item in entities)
                            {
                                command.Parameters["@MABDM"].Value = item.MABDM;
                                command.Parameters["@MALHKT"].Value = item.MALHKT;
                                command.Parameters["@DIEM"].Value = item.DIEM;
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
