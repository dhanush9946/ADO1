using System;
using ADO1Connection;
using Microsoft.Data.SqlClient;

class Program
{
    public static void Main()
    {
        //string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        //using (SqlConnection con=new SqlConnection(cs))
        //{
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("Select Id,Name FROM Employees;", con);
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        Console.WriteLine(dr["Id"] + " " + dr["Name"]);
        //    }

        //}
        Insert.Main1();
    }
}
