using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002
{
    class BookShelfContext: DbContext
    {
        public DbSet<Director> Directors { get; set; }
    }
}
