using examen_ba.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.DataAccess
{
    public class VisitasRepository
    {
        private SistemaVisitasContext _db;
        public VisitasRepository(SistemaVisitasContext db)
        {
            _db = db;
        }
        public List<Visita> GetVisitas()
        {  
            return _db.Visitas.Include(x => x.Visitado).Include(x => x.Visitante).ToList(); ;
        }
        public Visita GetVisita(int id)
        {
            return _db.Visitas.First(x => x.Id == id);
        }
    }
}
