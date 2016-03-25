using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleWebApplication.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Model Name")]
        public string ModelName { get; set; }

        public string Make { get; set; }

        public int Year { get; set; }

        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public Person Owner { get; set; }
    }
}