using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleadosContext : DbContext
    {

        public DBEmpleadosContext(DbContextOptions options):base(options) { }

        public virtual DbSet<Empleado> Empleados { get; set; }

    }
}
