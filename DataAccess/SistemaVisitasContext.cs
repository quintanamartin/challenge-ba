using examen_ba.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.DataAccess
{
    public class SistemaVisitasContext : DbContext
    {
        public SistemaVisitasContext(DbContextOptions<SistemaVisitasContext> options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Sector> Sectores { get; set; }
    }
}
