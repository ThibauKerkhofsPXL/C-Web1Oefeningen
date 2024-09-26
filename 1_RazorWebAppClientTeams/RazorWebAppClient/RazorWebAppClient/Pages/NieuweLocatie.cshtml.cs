using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebAppClient.Data;

namespace RazorWebAppClient.Pages
{
    public class NieuweLocatieModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string postcode = Request.Form["PostCode"];
            string city = Request.Form["Gemeente"];
            Databank.AddLocation(postcode, city);
            return RedirectToPage("Locaties");
        }
    }
}
