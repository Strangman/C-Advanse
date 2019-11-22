using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string task = @"select* from Movies";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["ToDataBaseConnection"].ToString();
                SqlCommand command = new SqlCommand(task, connection);
                connection.Open();
                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine($"Name: {sqlReader[0].ToString()}, \tGenre: {sqlReader[1].ToString()}," +
                            $"  \tYear: {sqlReader[2].ToString()}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
