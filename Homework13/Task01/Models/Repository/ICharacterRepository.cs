using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task01.Models.Repository
{
    public interface ICharacterRepository
    {
        List<Character> GetCharacters();
    }
}
