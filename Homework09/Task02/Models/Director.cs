using System.Data.Linq.Mapping;

namespace Task02.Models
{
    [Table(Name = "Director")]
    class Director
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Firstname { get; set; }
        [Column]
        public string LastName { get; set; }
        [Column]
        public int BirthDate { get; set; }
    }
}
