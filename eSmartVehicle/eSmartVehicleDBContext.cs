using eSmartVehicle.Models;
using Microsoft.EntityFrameworkCore;

namespace eSmartVehicle
{
    public class eSmartVehicleDBContext: DbContext
    {
        public eSmartVehicleDBContext():base()
        {
            
        }
        public eSmartVehicleDBContext(DbContextOptions contextOptions):base(contextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Color>().HasKey(c => c.ColorId);
            modelBuilder.Entity<Brand>();
        }
        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand { get; set; }
    }
}
