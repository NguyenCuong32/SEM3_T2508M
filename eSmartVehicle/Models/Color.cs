using System.ComponentModel.DataAnnotations;

namespace eSmartVehicle.Models
{
    public class Color
    {
        //[Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorHex { get; set; }
        public Color()
        {
            
        }
        public Color(int colorId, string colorName, string colorHex)
        {
            ColorId = colorId;
            ColorName = colorName;
            ColorHex = colorHex;
        }
        public Color(string colorName, string colorHex)
        {
            ColorName = colorName;
            ColorHex = colorHex;
        }

    }
}
