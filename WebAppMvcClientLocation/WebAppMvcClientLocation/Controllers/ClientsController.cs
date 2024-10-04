using Microsoft.AspNetCore.Mvc;
using WebAppMvcClientLocation.Data;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            var clients = Database.Clients;
            return View(clients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client c)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(c.ClientName) || c.ClientName.Length < 2)
                {
                    ModelState.AddModelError("ClientName", "ClientName is te kort!");
                    return View("Create", c);
                }

                
                var result = Database.AddClient(c);
                if (result.Succeeded == false)
                {
                    
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("ClientId", error); 
                    }
                    return View("Create", c);
                }

                
                return RedirectToAction("Index", "Clients");
            }

            return View("Create", c);
        }
    }
}
