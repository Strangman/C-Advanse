using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
    }
}
