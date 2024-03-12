using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
