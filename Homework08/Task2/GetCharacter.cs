using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GetCharacter
    {
        public static void GetCharacterInDb()
        {
            var dbContext = new BookShelfContext();
            var characters = dbContext.Characters;

            foreach (var c in characters)
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");
            Console.ReadKey();
        }
    }
}
