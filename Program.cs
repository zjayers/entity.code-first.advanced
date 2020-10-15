using System.Data.Entity;
using EntityFramework.CodeFirst.Advanced.Models;

namespace EntityFramework.CodeFirst.Advanced
{
    public class PlutoDbContext : DbContext
    {

        public PlutoDbContext() :base("name=DefaultConnection") { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
