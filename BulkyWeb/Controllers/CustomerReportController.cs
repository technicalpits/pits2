using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CustomerReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
