using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class RequestAQuotaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
