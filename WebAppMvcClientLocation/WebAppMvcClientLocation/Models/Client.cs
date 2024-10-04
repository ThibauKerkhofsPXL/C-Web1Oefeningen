using System.ComponentModel.DataAnnotations;
using WebAppMvcClientLocation.CustomModelValidations;

namespace WebAppMvcClientLocation.Models
{
    public class Client
    {
        [Required(ErrorMessage = "Probleem met de clientID")]
        public int? ClientId { get; set; }
        public int? LocationId { get; set; }
        [CustomNoNumbers]
        public string? ClientName { get; set; }

        public Client()
        {
            ClientId = -1;
            LocationId = -1;
            ClientName = string.Empty;
        }
        public Client(int id, int locationId, string naam)
        {
            ClientId = id;
            LocationId = locationId;
            ClientName = naam;
        }

        
    }
}
