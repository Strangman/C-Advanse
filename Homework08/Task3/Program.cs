using EntityFrameworkExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new BookShelfContext();
            var characters = CharactersService.GetCharacters();
            dbContext.Characters.AddRange(characters);

            dbContext.SaveChanges();
        }
    }
}
