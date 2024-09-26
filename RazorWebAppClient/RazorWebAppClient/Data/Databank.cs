namespace RazorWebAppClient.Data
{
    public class Databank
    {
        public static List<Klant> Klanten { get; set; }
        public static List<Klant> KlantenLand { get; set; }
        public static List<Locatie> Locaties { get; set; }
        public static void StartDatabank()
        {
            Klanten = new List<Klant>();
            Klanten.Add(new Klant(1, "Klant A"));
            Klanten.Add(new Klant(2, "Klant B"));
        }

        public static void StartDatabankLand()
        {
            KlantenLand = new List<Klant>();
            KlantenLand.Add(new Klant(3, "Yordi Vlierden Van", "Nederland"));
            KlantenLand.Add(new Klant(4, "Thibau Kerkhofs", "België"));

        }

        public static void StartDatabankGemeente()
        {
            Locaties = new List<Locatie>();
            Locaties.Add(new Locatie(1, 3500, "Hasselt"));
            Locaties.Add(new Locatie(2, 3600, "Genk"));
        }

    }
}
