using System.Linq;
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelfContext dbContext = new BookShelfContext();
            //dbContext.Database.ExecuteSqlCommand(@"SELECT m.Id, m.Name, m.Genre, m.Year, d.Id FROM ""Movies"" m INNER JOIN ""Directors"" d ON d.Id = m.DirectorId");
            //dbContext.SaveChanges();
            var characters = dbContext.Movies.Where(x=>x.Genre == "Action");
            dbContext.Movies.RemoveRange(characters);

            dbContext.SaveChanges();

            //задание 3* Находится в Homework09\Foreign Key в виде скинов
        }
    }
}
