using ProjectV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Models.Repository
{
    public class StudioRepository : IStudioRepository
    {
        public List<Studio> GetStudios()
        {
            var context = new ProjectV2Context();

            return context.Studios.ToList();
        }
    }
}
