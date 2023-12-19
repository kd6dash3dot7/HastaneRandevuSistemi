using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class PoliklinikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
