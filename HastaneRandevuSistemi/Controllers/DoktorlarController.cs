using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class DoktorlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
