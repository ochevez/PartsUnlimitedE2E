using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Manufacturer
    {
        // Modificando cs denominado Manufacturer
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}