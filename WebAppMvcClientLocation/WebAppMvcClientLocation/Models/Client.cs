using System.ComponentModel.DataAnnotations;

namespace WebAppMvcClientLocation.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public int LocationId { get; set; }
        public string ClientName { get; set; }

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
