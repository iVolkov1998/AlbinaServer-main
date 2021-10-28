
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Albina.DataAccess.Core.Models
{
    [Table("User")]
    class UserRto
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string NumberPrefix { get; set; }

        public string Number { get; set; }

    }
}
