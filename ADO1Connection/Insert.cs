using System;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class Insert
    {
        public static void Main1()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employees (Name) VALUES ('vijayasree')", con);
            int row = cmd.ExecuteNonQuery();
            Console.WriteLine(row + "rows affected");
        }
    }
}
