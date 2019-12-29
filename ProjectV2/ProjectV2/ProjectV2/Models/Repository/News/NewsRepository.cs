using ProjectV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Models.Repository
{
    public class NewsRepository : INewsRepository
    {
        public List<News_single> GetNews()
        {
            var context = new ProjectV2Context();

            return context.News.ToList();
        }
    }
}
