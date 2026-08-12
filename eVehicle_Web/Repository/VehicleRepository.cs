using eVehicle_Web.Models;

namespace eVehicle_Web.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly eVehicleDbContext eVehicleDbContext;

        public VehicleRepository(eVehicleDbContext eVehicleDbContext)
        {
            this.eVehicleDbContext = eVehicleDbContext;
        }

        public Vehicle GetVehicleById(Int64 vehicleId)
        {
            return this.eVehicleDbContext.Vehicle.Where(t => t.VehicleId == vehicleId).FirstOrDefault();
        }

        public List<Vehicle> GetVehicles()
        {
            return this.eVehicleDbContext.Vehicle.ToList();
        }
    }
}
