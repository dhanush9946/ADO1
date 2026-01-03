using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection.ConnectedArchitecture
{
    internal class SPGetById
    {
        public static void Main18()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("GetById", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", 1);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) { Console.WriteLine(dr["Name"]); }
        }
    }
}
