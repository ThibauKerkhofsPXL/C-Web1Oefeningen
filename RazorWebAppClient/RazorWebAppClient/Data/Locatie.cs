namespace RazorWebAppClient.Data
{
    public class Locatie
    {
        public int LocatieId { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }

        public Locatie()
        {
            LocatieId = -1;
            Postcode = -1;
            Gemeente = string.Empty;
        }
        public Locatie(int id, int postcode, string gemeente)
        {
            LocatieId = id;
            Postcode = postcode;
            Gemeente = gemeente;
        }
    }
}
