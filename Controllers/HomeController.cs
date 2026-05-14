using Microsoft.AspNetCore.Mvc;
using IDGS904ASP.Models;
using System.Collections.Generic;

namespace IDGS904ASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public RedirectToActionResult Index()
        {
            return RedirectToAction("Index", "Pruebas");
        }

        /*
        public RedirectResult Index()
        {
            return Redirect("https://www.google.com/");
        }

        public JsonResult Index()
        {
            var alumno1 = new Personas()
            {
                Nombre = "Juan",
                Edad = 32,
                Empleado = true
            };

            var alumno2 = new Personas()
            {
                Nombre = "Maria",
                Edad = 32,
                Empleado = false
            };

            return Json(new List<Personas> { alumno1, alumno2 });
        }
        */

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}