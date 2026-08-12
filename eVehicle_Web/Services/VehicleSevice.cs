using eVehicle_Web.Models;
using eVehicle_Web.Repository;

namespace eVehicle_Web.Services
{
    public class VehicleSevice : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleSevice(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        public Vehicle GetVehicleById(long vehicleId)
        {
           return this.GetVehicleById(vehicleId);
        }

        public List<Vehicle> GetVehicles()
        {
           return vehicleRepository.GetVehicles();  
        }
    }
}
