using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Data
{
    public class Database
    {
        public static List<Client> Clients { get; set; } = new List<Client>();
        public static List<Location> Locations { get; set; } = new List<Location>();

        public static void StartDatabase()
        {
            AddCustomer("Yordi", 1);
            AddCustomer("Lennert", 2);
            AddLocation("3530", "Helchteren");
            AddLocation("3500", "Hasselt");

        }

        public static void AddCustomer(string naam, int locationId)
        {
            int id = 1;
            if (Clients.Count > 1 )
            {
                id = Clients.Max(x => x.ClientId) + 1;
            }
            Clients.Add(new Client(id, locationId, naam));
        }

        public static void AddLocation(string postcode, string city)
        {
            int id = 1;
            if (Locations.Count > 1)
            {
                id = Locations.Max(x => x.LocationId) + 1;
            }
            Locations.Add(new Location(id, postcode, city));
        }

        public static InsertResult AddClient(Client c)
        {
            return null;
        }

        public static InsertResult AddLocation(Location l)
        {
            return null;
        }

    }
}
