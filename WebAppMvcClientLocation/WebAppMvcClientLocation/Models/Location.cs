using System.ComponentModel.DataAnnotations;
using WebAppMvcClientLocation.CustomModelValidations;

namespace WebAppMvcClientLocation.Models
{
    public class Location
    {
        public int? LocationId { get; set; }

        [CustomPostcode]
        public string? PostCode { get; set; }

        [Required(ErrorMessage = "Gemeente is verplicht.")]
        public string? City { get; set; }

        public Location()
        {
            LocationId = -1;
            PostCode = string.Empty;
            City = string.Empty;
        }

        public Location(int locationId, string postcode, string city)
        {
            LocationId = locationId;
            PostCode = postcode;
            City = city;
        }
    }
}
