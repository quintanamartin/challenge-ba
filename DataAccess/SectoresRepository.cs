using examen_ba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_ba.DataAccess
{
    public class SectoresRepository
    {
        private SistemaVisitasContext _db;
        public SectoresRepository(SistemaVisitasContext db)
        {
            _db = db;
        }

        public List<Sector> GetSectores()
        {
            return _db.Sectores.ToList();
        }
    }
}
