using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1Connection
{
    internal class SPWithReturnValue
    {
        public static void Main8()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_AddEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", "hayyoda");
            cmd.Parameters.AddWithValue("@Age", 19);

            SqlParameter returnParameter = new SqlParameter();
            returnParameter.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add(returnParameter);
            cmd.ExecuteNonQuery();

            int result = (int)returnParameter.Value;
            Console.WriteLine(result);
        }
    }
}
