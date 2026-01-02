using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class MultipleQueries
    {
        public static void Main14()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employees;Select * from Students;", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["Name"]);
            }
            dr.NextResult();
            while (dr.Read())
            {
                Console.WriteLine(dr["FirstName"]);
            }

        }
    }
}
