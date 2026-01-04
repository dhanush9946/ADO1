using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class Transaction
    {
        public static void Main24()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Employees values ('Amit',10000,'financial')", con, transaction);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("UPDATE Employees set Salary=Salary+5000 where Name='Amit'", con, transaction);
                    cmd2.ExecuteNonQuery();

                    Console.WriteLine("Transaction completed successfully");


                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction failed");
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
