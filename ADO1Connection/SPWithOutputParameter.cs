using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1Connection
{
    internal class SPWithOutputParameter
    {
        public static void Main7()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_GetEmployeeCount", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter outputParameter = new SqlParameter("@TotalCount", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(outputParameter);

            cmd.ExecuteNonQuery();

            int count = (int)cmd.Parameters["@TotalCount"].Value; 
            Console.WriteLine(count);
        }
    }
}
