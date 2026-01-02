using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class DeleteRow
    {
        public static void Main12()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            ds.Tables["Employees"].Rows[0].Delete();

            Console.WriteLine(ds.Tables["Employees"].Rows[1]["Name"]);
        }
    }
}
