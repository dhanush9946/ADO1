using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO1Connection
{
    internal class Task3
    {
        public static void Main25()
        {
            string cs = "Server=.;Database=TestDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            //using (SqlConnection con = new SqlConnection(cs))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("GetStudentById", con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@Id", 4);
            //    SqlDataReader dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        Console.WriteLine(dr["name"] + "---" + dr["Age"]);
            //    }
            //    Console.WriteLine("--------------------------------------------------------------");
            //}
            //using (SqlConnection con2 = new SqlConnection(cs))
            //{ 

            //    con2.Open();
            //    SqlCommand cmd2 = new SqlCommand("InsertStudent", con2);
            //    cmd2.CommandType = CommandType.StoredProcedure;

            //    cmd2.Parameters.AddWithValue("@Id", "17");
            //    cmd2.Parameters.AddWithValue("@Name", "Manu");
            //    cmd2.Parameters.AddWithValue("@Age", "18");
            //    cmd2.Parameters.AddWithValue("@Email", "Manu@ggmail.com");

            //    int row = cmd2.ExecuteNonQuery();
            //    Console.WriteLine(row + "Affected"+"CRUD INSERT");
            //    con2.Close();

            //    con2.Open();
            //    SqlCommand cmd3 = new SqlCommand("GetAll", con2);
            //    cmd3.CommandType = CommandType.StoredProcedure;
            //    SqlDataReader dr = cmd3.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        Console.WriteLine(dr["Name"]+"   ---"+ dr["Age"]+"CRUD READ");
            //    }
            //    con2.Close();
            //    con2.Open();
            //    SqlCommand cmd4 = new SqlCommand("UpdateStudent", con2);
            //    cmd4.CommandType = CommandType.StoredProcedure;
            //    cmd4.Parameters.AddWithValue("@Id", 1);
            //    cmd4.Parameters.AddWithValue("Age", 27);
            //    cmd4.ExecuteNonQuery();
            //    Console.WriteLine("Updated Successfully"+"CRUD UPDATE");
            //    con2.Close();
            //    con2.Open();
            //    SqlCommand cmd5 = new SqlCommand("DeleteStudent", con2);
            //    cmd5.CommandType = CommandType.StoredProcedure;

            //    cmd5.Parameters.AddWithValue("@Id", 2);
            //    cmd5.ExecuteNonQuery();
            //    Console.WriteLine("Deleted successfully"+"CRUD DELETE");

            //    Console.WriteLine("---------------------------------------------------------------");
            //}
            using (SqlConnection con3 = new SqlConnection(cs))
            {
                con3.Open();
                SqlTransaction transaction = con3.BeginTransaction();

                try
                {
                    SqlCommand cmd6 = new SqlCommand("InsertStudent", con3, transaction);
                    cmd6.CommandType = CommandType.StoredProcedure;

                    cmd6.Parameters.AddWithValue("@Id", 15);
                    cmd6.Parameters.AddWithValue("@Name", "Binuoo Transaction");
                    cmd6.Parameters.AddWithValue("@Age", 58);
                    cmd6.Parameters.AddWithValue("@Email", "binu@gmail.com");

                    cmd6.ExecuteNonQuery();
                    Console.WriteLine("Student inserted successfully");

                    SqlCommand cmd7 = new SqlCommand("UpdateStudent", con3, transaction);
                    cmd7.CommandType = CommandType.StoredProcedure;

                    cmd7.Parameters.AddWithValue("@Id", 3);
                    cmd7.Parameters.AddWithValue("@Age", 43);
                    cmd7.ExecuteNonQuery();

                    Console.WriteLine("updated successfully");
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction failed");
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
