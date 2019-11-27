using Task01.Models;
using System.Data.Linq;
using System.Configuration;
using Task01.Service;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["BookShelfContext"].ToString());

            //dataContext.GetTable<Director>().InsertOnSubmit(new Director() { Firstname = "Lilly", LastName = "Wachowski", BirthDate = 1967 });

            dataContext.GetTable<Director>().InsertAllOnSubmit(DirectorService.GetDirectors());
            dataContext.SubmitChanges();
        }
    }
}
