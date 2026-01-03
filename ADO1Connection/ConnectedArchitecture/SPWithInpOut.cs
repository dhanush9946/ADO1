using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection.ConnectedArchitecture
{
    internal class SPWithInpOut
    {
        public static void Main20()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", "Anu");
            cmd.Parameters.AddWithValue("@Salary", 50000);
            cmd.Parameters.AddWithValue("@Department", "cs");

            SqlParameter outputparam = new SqlParameter("@newEmpId", SqlDbType.Int);
            outputparam.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(outputparam);
            cmd.ExecuteNonQuery();

            int EmpId = (int)cmd.Parameters["@newEmpId"].Value;
            Console.WriteLine(EmpId);
        }
    }
}
