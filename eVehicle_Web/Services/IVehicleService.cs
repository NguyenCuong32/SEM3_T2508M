using eVehicle_Web.Models;

namespace eVehicle_Web.Services
{
    public interface IVehicleService
    {
        public List<Vehicle> GetVehicles();
        public Vehicle GetVehicleById(Int64 vehicleId);
    }
}
