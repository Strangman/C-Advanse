using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Foundation { get; set; }
        public string Discription { get; set; }
        public string ImgLink { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<DLC> DLCs { get; set; }
        public Studio()
        {
            Games = new List<Game>();
            DLCs = new List<DLC>();
        }
    }
}
