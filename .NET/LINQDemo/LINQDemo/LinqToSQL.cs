using System;
using System.Data.SqlClient;

class LinqToSQL
{
    static string connectionString =  "Server=local;Database=master;Trusted_Connection=True;";


    public static void Execute()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT Name FROM Students WHERE Age > 22";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("Students older than 22:");
                while (reader.Read())
                {
                    Console.WriteLine(reader["Name"]);
                }
            }
        }
    }
}

