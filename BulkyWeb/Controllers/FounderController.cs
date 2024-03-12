using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class FounderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
