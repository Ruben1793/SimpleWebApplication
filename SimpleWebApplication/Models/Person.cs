using System.ComponentModel.DataAnnotations;

namespace SimpleWebApplication.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public Phonetype PhoneType { get; set; }

        public enum Phonetype
        {
            Home,
            Work,
            Other
        }
    }
}