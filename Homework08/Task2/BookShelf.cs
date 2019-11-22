using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExample.Models;

namespace Task2
{
    public class BookShelfContext: DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
