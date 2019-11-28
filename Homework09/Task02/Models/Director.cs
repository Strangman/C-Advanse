using System.Data.Linq.Mapping;

namespace Task02.Models
{
    class Director
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }
    }
}
