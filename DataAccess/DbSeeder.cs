using examen_ba.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.DataAccess
{
    public static class  DbSeeder
    {
        public static void Initialize(SistemaVisitasContext context)
        {
            context.Personas.AddRange(
                new Persona() { Id = 1, DNI = 34343434, Nombre = "Juan", Apellido = "Perez" },
                new Persona() { Id = 2, DNI = 34287434, Nombre = "Pedro", Apellido = "Martinez" },
                new Persona() { Id = 3, DNI = 23413434, Nombre = "Pablo", Apellido = "Sanchez" },
                new Persona() { Id = 4, DNI = 42343234, Nombre = "Jose", Apellido = "Vivas" }
            );

            context.Sectores.AddRange(
                new Sector() { Id = 1, Nombre = "Legales" },
                new Sector() { Id = 2, Nombre = "Escribania" },
                new Sector() { Id = 3, Nombre = "Auditoria" },
                new Sector() { Id = 4, Nombre = "Normativa" }
                );
            context.Empleados.AddRange(
                new Empleado() { Id = 1, Nombre = "Rocio", Apellido = "Diaz", IdSector = 1 },
                new Empleado() { Id = 2, Nombre = "Sebastian", Apellido = "Parasis", IdSector = 2 },
                new Empleado() { Id = 3, Nombre = "Walter", Apellido = "Marcote", IdSector = 4 },
                new Empleado() { Id = 4, Nombre = "Guillermo", Apellido = "Balcarcel", IdSector = 1 },
                new Empleado() { Id = 5, Nombre = "Enzo", Apellido = "Peddini", IdSector = 3 }
                );
            context.Visitas.AddRange(
                new Visita() { Id = 1, NumeroTarjeta = 12, IdVisitante = 1, IdEmpleado = 1, FechaIngreso = DateTime.Now },
                new Visita() { Id = 2, NumeroTarjeta = 32, IdVisitante = 2, IdEmpleado = 2, FechaIngreso = DateTime.Now },
                new Visita() { Id = 3, NumeroTarjeta = 41, IdVisitante = 3, IdEmpleado = 5, FechaIngreso = DateTime.Now },
                new Visita() { Id = 4, NumeroTarjeta = 15, IdVisitante = 4, IdEmpleado = 4, FechaIngreso = DateTime.Now },
                new Visita() { Id = 5, NumeroTarjeta = 61, IdVisitante = 2, IdEmpleado = 2, FechaIngreso = DateTime.Now },
                new Visita() { Id = 6, NumeroTarjeta = 81, IdVisitante = 3, IdEmpleado = 1, FechaIngreso = DateTime.Now },
                new Visita() { Id = 7, NumeroTarjeta = 11, IdVisitante = 1, IdEmpleado = 4, FechaIngreso = DateTime.Now }
                );

            context.SaveChanges();
        }
    }
}
