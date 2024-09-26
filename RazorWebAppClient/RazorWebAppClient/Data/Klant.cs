namespace RazorWebAppClient.Data
{
    public class Klant
    {

        public Klant()
        {
            KlantId = -1;
            KlantNaam = string.Empty;
            KlantLand = string.Empty;
        }
        public Klant(int id, string naam)
        {
            KlantId = id;
            KlantNaam = naam;
            KlantLand = string.Empty;
        }

        public Klant(int id, string naam, string land)
        {
            KlantId = id;
            KlantNaam = naam;
            KlantLand = land;
        }


        public int KlantId { get; set; }
        public string KlantNaam { get; set; }
        public bool GevalideerdeKlant => (KlantId > -1);
        public string KlantLand { get; set; }

    }
}
