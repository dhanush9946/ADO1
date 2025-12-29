using System;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class CreateStoredProcedure
    {
        public static void Main5()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("CREATE PROCEDURE sp_GetName as begin select Name from Employees end", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("sp created successfully");
        }
    }
}
