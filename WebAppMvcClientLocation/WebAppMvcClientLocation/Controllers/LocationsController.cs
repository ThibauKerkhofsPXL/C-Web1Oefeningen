using Microsoft.AspNetCore.Mvc;
using WebAppMvcClientLocation.Data;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            var locations = Database.Locations;
            return View(locations);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Location c)
        {
            Database.AddLocation(c.PostCode, c.City);
            return RedirectToAction("Index", "Locations");
        }
    }
}
