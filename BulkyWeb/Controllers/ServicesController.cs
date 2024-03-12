using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
