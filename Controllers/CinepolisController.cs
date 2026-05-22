using IDGS904ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cinepolis cine)
        {
            cine.Calcular();

            return View(cine);
        }
    }
}