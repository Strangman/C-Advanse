using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string task = @"insert into Movies(Name, Genre, Year) values('John Wick', 'Action', 2014) 
            insert into Movies(Name, Genre, Year) values('John Wick 2', 'Action', 2017)
            insert into Movies(Name, Genre, Year) values('John Wick 3', 'Action', 2019)";

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
