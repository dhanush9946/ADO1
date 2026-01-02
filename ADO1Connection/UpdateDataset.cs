using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class UpdateDataset
    {
        public static void Main11()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            DataRow row = ds.Tables["Employees"].Rows[0];
            row["Age"] = 30;

            DataRow roww = ds.Tables["Employees"].Rows[0];
            Console.WriteLine(roww["Name"] + "-----" + roww["Age"]);
        }
    }
}
