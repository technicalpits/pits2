using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class DownloadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
