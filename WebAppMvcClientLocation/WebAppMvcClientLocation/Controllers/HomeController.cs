using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ClientCount = Data.Database.Clients.Count;
            ViewBag.LocationCount = Data.Database.Locations.Count;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult HomeViewbag()
        {
            ViewBag.ClientCount = Data.Database.Clients.Count;
            ViewBag.LocationCount = Data.Database.Locations.Count;
            return View();
        }
    }
}
