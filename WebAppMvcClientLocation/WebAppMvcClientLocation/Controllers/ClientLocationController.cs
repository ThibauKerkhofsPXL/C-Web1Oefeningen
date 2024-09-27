using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientLocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
