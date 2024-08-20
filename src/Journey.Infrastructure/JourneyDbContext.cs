using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Journey.Infrastructure
{
    public class JourneyDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\guilh\\Downloads\\JourneyDatabase.db");
        }
    }
}
