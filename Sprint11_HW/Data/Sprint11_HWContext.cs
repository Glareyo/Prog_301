using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sprint11_HW.Models;

namespace Sprint11_HW.Data
{
    public class Sprint11_HWContext : DbContext
    {
        public Sprint11_HWContext (DbContextOptions<Sprint11_HWContext> options)
            : base(options)
        {
        }

        public DbSet<Sprint11_HW.Models.Human> Human { get; set; } = default!;
    }
}
