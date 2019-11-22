using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string task = @"CREATE TABLE Movies (
            Name NVARCHAR(50) NOT NULL,
            Genre NVARCHAR(50) NOT NULL,
            Year INT NOT NULL)";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["ToDataBaseConnection"].ToString();
                SqlCommand command = new SqlCommand(task, connection);
                connection.Open();
                var rowAffect = command.ExecuteNonQuery();
            }
        }
    }
}
