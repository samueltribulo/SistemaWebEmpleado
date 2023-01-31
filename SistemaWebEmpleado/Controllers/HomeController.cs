using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebEmpleado.Controllers
{
    public class HomeController : Controller { 
    
        public IActionResult Index()
        {
            ViewBag.Saludo = "Bienvenido al sitio web!";
            ViewBag.Fecha = DateTime.Now.ToString("dd-MM-yyyy");

            return View();
        }
    }
}
