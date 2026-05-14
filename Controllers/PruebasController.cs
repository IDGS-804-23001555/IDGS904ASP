using IDGS904ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IDGS904ASP.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            ViewBag.Nombre = "Yutzil Sanchez";
            ViewBag.Titulo = "MISEC";
            ViewData["Materia"] = "DWI";

            return View();
        }

        public IActionResult Empleado()
        {
            var persona = new Personas()
            {
                Nombre = "Claudia",
                Edad = 20,
                Empleado = true,
                Nacimiento = new DateTime(2000, 1, 1)
            };

            ViewBag.Propiedad = persona;

            return View();
        }
    }
}