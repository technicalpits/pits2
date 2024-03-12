using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class PrivacyTermController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
