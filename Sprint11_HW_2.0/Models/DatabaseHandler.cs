using Microsoft.EntityFrameworkCore;

namespace Sprint11_HW_2._0.Models
{
    public class DatabaseHandler : DbContext
    {
        public DbSet<IHuman> Humans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Database");
        }
    }
}
