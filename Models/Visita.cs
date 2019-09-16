using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.Models
{
    public class Visita
    {
        public int Id { get; set; }
        public int IdVisitante { get; set; }
        [ForeignKey("IdVisitante")]
        public Persona Visitante { get; set; }
        public long NumeroTarjeta { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public Empleado Visitado { get; set; }
    }
}
