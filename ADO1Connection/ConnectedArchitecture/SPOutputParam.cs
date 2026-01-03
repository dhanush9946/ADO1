using System;
using System.Data;
using System.Reflection.Metadata;
using Microsoft.Data.SqlClient;

namespace ADO1Connection.ConnectedArchitecture
{
    internal class SPOutputParam
    {
        public static void Main19()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("GetEmployeeCount", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter outputparam = new SqlParameter("@TotalEmployees", SqlDbType.Int);
            outputparam.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(outputparam);

            
            cmd.ExecuteNonQuery();

            int count = (int)cmd.Parameters["@TotalEmployees"].Value;
            Console.WriteLine(count);

        }
    }
}
