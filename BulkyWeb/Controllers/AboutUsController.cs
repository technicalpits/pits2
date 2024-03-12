using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
