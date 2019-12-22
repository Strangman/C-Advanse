using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task01.Models.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        public List<Character> GetCharacters() 
        {
            var context = new Task01Context();

            return context.Characters.ToList();
        }
    }
}
