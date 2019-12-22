using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Game_Store
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int GameId { get; set; }
        public int StoreId { get; set; }
    }
}
