using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ImgLink { get; set; }
        public string Device { get; set; }
        public int Price { get; set; }
        public string Discription { get; set; }
        public string BuyLink { get; set; }
        public int? StudioId { get; set; }
        public Studio Studio { get; set; }
        public ICollection<News_single> News { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; }
        public ICollection<DLC> DLCs { get; set; }
        public Game()
        {
            News = new List<News_single>();
            DLCs = new List<DLC>();
        }
    }
}
