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
            Clients.Add(new Client(2, 2, "Lennert"));
            AddLocation("3530", "Helchteren");
            Locations.Add(new Location(2, "3500", "Hasselt"));
            Locations.Add(new Location(3, "3520", "Testing"));

        }

        public static void AddCustomer(string naam, int locationId)
        {
            int id = 1;
            if (Clients.Count > 1 )
            {
                id = (int)(Clients.Max(x => x.ClientId) + 1);
            }
            Clients.Add(new Client(id, locationId, naam));
        }

        public static void AddLocation(string postcode, string city)
        {
            int newLocationId = 1;

            if (Locations.Count > 1)
            {
                newLocationId = ((int)(Locations.Max(x => x.LocationId) + 1));
            }
            Locations.Add(new Location(newLocationId, postcode, city));
        }


        public static InsertResult AddClient(Client c)
        {
            var result = new InsertResult { Errors = new List<string>() };

            if (c.ClientId < 1)
            {
                result.Succeeded = false;
                result.Errors.Add("ClientId moet groter zijn dan 0!");
                return result;
            }

            if (Clients.Any(x => x.ClientId == c.ClientId))
            {
                result.Succeeded = false;
                result.Errors.Add("ClientId bestaat al!");
                return result;
            }

            Clients.Add(c);
            result.Succeeded = true;
            return result;
        }

        public static InsertResult AddLocation(Location l)
        {
            var result = new InsertResult { Errors = new List<string>() };

            if (string.IsNullOrWhiteSpace(l.PostCode))
            {
                result.Succeeded = false;
                result.Errors.Add("Postcode is verplicht.");
            }

            if (string.IsNullOrWhiteSpace(l.City))
            {
                result.Succeeded = false;
                result.Errors.Add("Gemeente is verplicht.");
            }

            if (result.Errors.Count > 0)
            {
                result.Succeeded = false;
                return result;
            }

            int newLocationId = 1;

            if (Locations.Count > 1)
            {
                newLocationId = ((int)(Locations.Max(x => x.LocationId) + 1));
            }

            l.LocationId = newLocationId;

            Locations.Add(l);
            result.Succeeded = true;

            return result;
        }

    }
}
