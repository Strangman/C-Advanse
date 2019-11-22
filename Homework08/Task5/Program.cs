using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkNavigationProperties.Models;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbContest = new BookShelfContext();
            DbContest.Movies.Add(new Movie() {Name= "Matrix", Genre="Action",Year=1997 });
            DbContest.SaveChanges();
        }
    }
}
