﻿namespace RazorWebAppClient.Data
{
    public class Databank
    {
        public static List<Klant> Klanten { get; set; }
        public static List<Locatie> Locaties { get; set; }
        public static void StartDatabank()
        {
            Klanten = new List<Klant>();
            Locaties = new List<Locatie>();
            Klanten.Add(new Klant(1, "Klant A", 1));
            Klanten.Add(new Klant(2, "Klant B", 2));
            Locaties.Add(new Locatie(1, "3500", "Hasselt"));
            Locaties.Add(new Locatie(2, "3600", "Genk"));
        }
        public static void AddLocation(string postcode, string city)
        {
            int id = Locaties.Max(x => x.LocatieId) + 1;
            Locaties.Add(new Locatie(id, postcode, city));
        }

        public static void AddCustomer(string naam, int locatieId)
        {
            int id = Klanten.Max(x => x.KlantId) + 1;
            Klanten.Add(new Klant(id, naam, locatieId));
        }

    }
}
