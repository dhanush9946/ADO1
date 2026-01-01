using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1Connection
{
    internal class DisconnectedArchitecture
    {
        public static void Main9()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            foreach(DataRow row in ds.Tables["Employees"].Rows)
            {
                Console.WriteLine(row["Name"] + "_" + row["Age"]);
            }
        }
    }
}
