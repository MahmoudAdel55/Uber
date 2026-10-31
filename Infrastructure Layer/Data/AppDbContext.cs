using Domain_Layer.Entities.Drivers;
using Domain_Layer.Entities.Passengers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Data
{
    internal class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasData(
         new Driver { Id = 1, Code = "1001", Name = "Ahmed", Price = 15 },
         new Driver { Id = 2, Code = "1002", Name = "Mohamed", Price = 19 },
         new Driver { Id = 3, Code = "1003", Name = "Ali", Price = 12 }
         );

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
