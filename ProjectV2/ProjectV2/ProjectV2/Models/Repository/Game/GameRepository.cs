using ProjectV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Models.Repository
{
    public class GameRepository : IGameRepository
    {
        public List<Game> GetGames()
        {
            var context = new ProjectV2Context();

            return context.Games.ToList();
        }
    }
}
