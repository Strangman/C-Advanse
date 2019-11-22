using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"insert into FirstTable ([Name],[Surname],[Age]) values ('Valeriy', 'Leontiev', 104)";
            string task = @"update FirstTable set Surname = 'Andropov' where Name = 'Valeriy'";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["ToDataBaseConnection"].ToString();
                SqlCommand command = new SqlCommand(task, connection);
                connection.Open();
                var rowAffect = command.ExecuteNonQuery();
                Console.WriteLine(rowAffect);
            }
        }
    }
}
