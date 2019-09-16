using examen_ba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.DataAccess
{
    public class PersonasRepository
    {
        private SistemaVisitasContext _db;
        public PersonasRepository(SistemaVisitasContext db)
        {
            _db = db;
        }
        public List<Persona> GetPersonas()
        {
            return _db.Personas.ToList();
        }
        public Persona GetByDni(long dni)
        {
            return _db.Personas.FirstOrDefault(x => x.DNI == dni);
        }
    }
}
