using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentManagement.Student
{
    class ConnectionToSql
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection("server=(local); database=QLHS; integrated security =true");
        }
    }
}
