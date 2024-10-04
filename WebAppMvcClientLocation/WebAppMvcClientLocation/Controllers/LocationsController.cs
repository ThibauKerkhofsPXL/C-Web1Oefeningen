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
        public IActionResult Create(Location l)
        {
            if (!ModelState.IsValid)
            {
                return View(l); 
            }

            
            InsertResult result = Database.AddLocation(l);

            
            if (!result.Succeeded.HasValue || result.Succeeded == false)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error); 
                }
                return View(l); 
            }

            return RedirectToAction("Index", "Locations");
        }

    }
}
