using System.Data.Entity;

namespace SimpleWebApplication.Models
{
    public class QuickAgenda :DbContext
    {
        public QuickAgenda() : base("Name=QuickAgenda"){}
        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}