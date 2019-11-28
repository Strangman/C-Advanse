using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class BookShelfContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
