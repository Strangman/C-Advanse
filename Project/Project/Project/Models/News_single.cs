using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class News_single
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int? GamesId { get; set; }
        public Game Games { get; set; }
    }
}
