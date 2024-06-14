using Microsoft.EntityFrameworkCore;
using static Persons;

namespace bank.DbCore
{
    public class DbReserch
    {
        public class ApplicationContext : DbContext
        {
            public DbSet<User> Users { get; set; }

            public ApplicationContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=bankdb;Trusted_Connection=True;");
            }
        }
    }
}
