using Microsoft.Data.SqlClient;
using System.Data;


namespace ADO1Connection
{
    internal class GetSingleEmp
    {
        public static void Main22()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("GetById", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.InsertCommand.Parameters.AddWithValue("@Id", 2);

            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(row["Name"]);
            }
        }
    }
}
