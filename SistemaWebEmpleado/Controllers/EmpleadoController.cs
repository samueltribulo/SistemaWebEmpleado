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

        public IActionResult Index(IEnumerable<Empleado> empleados)
        {
            if(empleados.Count() == 0)
            {
                var todosLosEmpleados = _context.Empleados.ToList();
                return View(todosLosEmpleados);
            }

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

        [HttpGet]
        public ActionResult FilterByTitle(string Titulo) {

            IEnumerable<Empleado> empleados = _context.Empleados.Where(e => e.Titulo == Titulo).ToList();

            return View("Index", empleados);

        }
    }
}
