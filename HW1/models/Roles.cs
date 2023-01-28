using Microsoft.EntityFrameworkCore;

namespace HW1.classes
{
    public class Roles : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bank.sqlite");
        }
    }
}
