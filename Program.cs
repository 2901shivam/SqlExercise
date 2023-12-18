using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        
        string connectionString = "server=SHIVAMSINGH;database=Assignment08;trusted_connection=true;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT TOP 5 PId, Pname, PPrice, MnfDate, ExpDate FROM Products ORDER BY Pname DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("{0,-10} {1,-15} {2,-10} {3,-15} {4,-15}", "PId", "PName", "PPrice", "MnfDate", "ExpDate");
                    Console.WriteLine(new string('-', 65));

                    while (reader.Read())
                    {
                        string PId = reader["PId"].ToString();
                        string Pname = reader["Pname"].ToString();
                        double PPrice = (double)reader["PPrice"];
                        DateTime MnfDate = (DateTime)reader["MnfDate"];
                        DateTime ExpDate = (DateTime)reader["ExpDate"];

                        Console.WriteLine("{0,-10} {1,-15} {2,-10:C2} {3,-15:yyyy-MM-dd} {4,-15:yyyy-MM-dd}",
                                          PId, Pname, PPrice, MnfDate, ExpDate);
                    }
                }
            }
        }

        Console.ReadLine(); // Pause to see the output
    }
}
