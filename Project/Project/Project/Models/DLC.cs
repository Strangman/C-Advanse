using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class DLC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
        public Studio Studio { get; set; }
        public int? StudioId { get; set; }
        public string BuyLink { get; set; }
        public string ImgLink { get; set; }
        public Game Game { get; set; }
        public int? GameId { get; set; }
    }
}
