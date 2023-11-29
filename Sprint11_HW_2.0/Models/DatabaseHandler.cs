using Microsoft.EntityFrameworkCore;

namespace Sprint11_HW_2._0.Models
{
    //Credits
    // http.www.youtube.com/watch?v=pmWFzzU_NB4
    // tutorialsEU - C# => Demonstrated implentation of Razor and pages.
    public class DatabaseHandler : DbContext
    {

        public DbSet<IHuman> Humans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Database");
        }
    }
}
