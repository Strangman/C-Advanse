using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkNavigationProperties.Models;

namespace Task5
{
    public class BookShelfContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
