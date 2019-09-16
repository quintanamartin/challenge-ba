using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
