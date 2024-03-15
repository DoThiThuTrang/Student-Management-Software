using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StudentManagement.Semester;

namespace StudentManagement.Semester
{
    class ConnectToSqlSemester
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection("Data Source=(local);database=QLHS;Integrated Security=True");
            
        }
    }
}
