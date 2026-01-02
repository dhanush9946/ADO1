using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class DataSetOperations
    {
        public  static void Main13()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            DataRow newRow = ds.Tables["Employees"].NewRow();
            newRow["Name"] = "rahulvarma gi";

            ds.Tables["Employees"].Rows.Add(newRow);

            foreach(DataRow row in ds.Tables["Employees"].Rows)
            {
                Console.WriteLine(row["Name"] +"---" + row["Age"]);
            }
        }
    }
}
