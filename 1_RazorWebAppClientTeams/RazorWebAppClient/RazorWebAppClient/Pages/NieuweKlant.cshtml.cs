using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebAppClient.Data;

namespace RazorWebAppClient.Pages
{
    public class NieuweKlantModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string klantnaam = Request.Form["Klantnaam"];
            string locatie = Request.Form["SelectLocatie"];
            if (int.TryParse(locatie, out int locatieId))
            {
                Databank.AddCustomer(klantnaam, locatieId);
            }
            
            return RedirectToPage("Klanten");
        }
    }
}
