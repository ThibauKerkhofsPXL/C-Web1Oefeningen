namespace WebAppMvcClientLocation.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public Location()
        {
            LocationId = -1;
            PostCode = string.Empty;
            City = string.Empty;
        }
        public Location(int locationId,string postcode, string city)
        {
            LocationId = locationId;
            PostCode = postcode;
            City = city;
        }
    }
}
