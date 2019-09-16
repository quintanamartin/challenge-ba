using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdSector { get; set; }
        public Sector Sector { get; set; }
    }
}
