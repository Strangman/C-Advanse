using System.Collections.Generic;
using Task01.Models;

namespace Task01.Service
{
    static class DirectorService
    {
        public static List<Director> GetDirectors()
        {
            var directors = new List<Director>();

            directors.Add(new Director() { Firstname = "Lana", LastName = "Wachowski", BirthDate = 1965 });
            directors.Add(new Director() { Firstname = "Michael", LastName = "Bay", BirthDate = 1965 });
            directors.Add(new Director() { Firstname = "Quentin", LastName = "Tarantino", BirthDate = 1963 });
            directors.Add(new Director() { Firstname = "Stanley", LastName = "Kubrick", BirthDate = 1999 });

            return directors;
        }
    }
}
