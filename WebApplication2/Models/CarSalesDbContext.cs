using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CarSalesDbContext : DbContext
    {
        public CarSalesDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { ID = 1, Type = "Car" },
                new VehicleType { ID = 2, Type = "Boat" },
                new VehicleType { ID = 3, Type = "Bike" });

            modelBuilder.Entity<BodyType>().HasData(
                new BodyType { ID = 1, Type = "Hatchback" },
                new BodyType { ID = 2, Type = "Seden" });
        }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
        public DbSet<BodyType> BodyType { get; set; }
    }
}
