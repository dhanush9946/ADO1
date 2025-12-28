using System;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class ExecuteSclar
    {
        public static void Main2()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select COUNT(*) from Employees", con);
            int count = (int)cmd.ExecuteScalar();
            Console.WriteLine(count);
        }
    }
}
