using eVehicle_Web.Models;

namespace eVehicle_Web.Repository
{
    public interface IVehicleRepository
    {
        public List<Vehicle> GetVehicles();
        public Vehicle GetVehicleById(Int64 vehicleId);
    }
}
