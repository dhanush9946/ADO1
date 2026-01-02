using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class Dataview
    {
        public static void Main15()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataView dv = new DataView(dt);
            dv.Sort = "Age DESC";
            
            foreach(DataRowView row in dv)
            {
                foreach(var item in row.Row.ItemArray)
                {
                    Console.WriteLine(item + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
