using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly DBEmpleadosContext _context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var empleados = _context.Empleados.ToList();

            return View(empleados);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }

        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Empleados.Add(empleado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }
    }
}
