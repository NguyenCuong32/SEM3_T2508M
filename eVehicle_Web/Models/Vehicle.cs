using System.ComponentModel.DataAnnotations;

namespace eVehicle_Web.Models
{
    public class Vehicle
    {
        [Key]
        public Int64 VehicleId { get; set; }
        public string? VehicleCode { get; set; }
        public string? LicensePlate { get; set; }
        public string? Vin { get; set; }
        public string? EngineNo { get; set; }
        public string? ModelName { get; set; }
        public int ManufactureYear { get; set; }
        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public int ColorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
