using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Models;

namespace Task02
{
    class BookShelfContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }
    }
}
