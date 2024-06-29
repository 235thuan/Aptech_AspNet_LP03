using LP03ClientSide.Models;
using Microsoft.EntityFrameworkCore;

namespace LP03ClientSide.Data
{
    public class AppDBContextcs : DbContext
    {
        public AppDBContextcs(DbContextOptions<AppDBContextcs> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        public DbSet<Work> Works { get; set; }

    }
}


