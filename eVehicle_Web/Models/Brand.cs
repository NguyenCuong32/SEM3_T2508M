using System.ComponentModel.DataAnnotations;

namespace eVehicle_Web.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
    }
}
