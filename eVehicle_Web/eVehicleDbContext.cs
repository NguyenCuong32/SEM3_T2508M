using eVehicle_Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace eVehicle_Web
{
    public class eVehicleDbContext: DbContext
    {
        public eVehicleDbContext():base()
        {
            
        }
        public eVehicleDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>();
            //modelBuilder.Entity<Color>();
            modelBuilder.Entity<Vehicle>();
            //modelBuilder.Entity<VehicleType>();
            //modelBuilder.Entity<VehicleInformation>().HasNoKey();
        }
        public DbSet<Brand> Brand { get; set; }
        //public DbSet<Color> Color { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        //public DbSet<VehicleType> VehicleType { get; set; }
        //public DbSet<VehicleInformation> VehicleInformation { get; set; }
    }
}
