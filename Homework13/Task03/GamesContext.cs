using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class GamesContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Store> Stores { get; set; }

        public DbSet<Game_Store> Games_Stores { get; set; }
    }
}
