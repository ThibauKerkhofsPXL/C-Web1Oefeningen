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
                if (c.ClientName == null || c.ClientName.Length < 2)
                {
                    ModelState.AddModelError("", "ClientName is te kort!");
                    return RedirectToAction("Index", "Clients");
                }

            }

            Database.Clients.Add(c);
            return RedirectToAction("Index", "Clients");
        }
    }
}
