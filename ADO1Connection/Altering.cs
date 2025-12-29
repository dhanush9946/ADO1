using System;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class Altering
    {
        public static void Main3()
        {


            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("Alter table Employees add Age INT", con);
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows + "affected");

        }
    }
}
