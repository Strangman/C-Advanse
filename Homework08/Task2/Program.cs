using EntityFrameworkExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new BookShelfContext();
            var characters = CharactersService.GetCharacters();
            foreach (var character in characters)
            {
                dbContext.Characters.Add(character);
            }

            dbContext.SaveChanges();
            GetCharacter.GetCharacterInDb();
        }
    }
}
