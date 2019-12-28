using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgLink { get; set; }
        public string Discription { get; set; }
        public string StoreLink { get; set; }
        public ICollection<Game> Games { get; set; }
        public Store()
        {
            Games = new List<Game>();
        }
    }
}
