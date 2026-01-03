using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace ADO1Connection
{
    internal class Task2
    {
        public static void Main16()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("Select * from Students", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            
            //Changing the Age......
            DataRow row = ds.Tables["Students"].Rows[0];
            row["Age"] = 21;
            Console.WriteLine(row["FirstName"] + "--" + row["Age"]);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds, "Students");

            //Filtering data with Dataview....
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);

            dv.RowFilter = "Age >22";
            foreach(DataRowView row1 in dv)
            {
                Console.WriteLine(
                                    row1["FirstName"]
                                    + "----" +
                                    row1["Age"]
                                 ); 
            }
        }
    }
}
