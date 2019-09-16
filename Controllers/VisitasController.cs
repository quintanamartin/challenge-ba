using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examen_ba.DataAccess;
using examen_ba.Models;
using Microsoft.AspNetCore.Mvc;

namespace examen_ba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitasController : ControllerBase
    {
        private VisitasRepository _repo;
        public VisitasController(VisitasRepository repo)
        {
            _repo = repo;
        }
        // GET: api/Visitas
        [HttpGet]
        public ActionResult<List<Visita>> Get()
        {
            return _repo.GetVisitas();
        }

        // GET: api/Visitas/5
        [HttpGet("{id}")]
        public ActionResult<Visita> Get(int id)
        {
            return _repo.GetVisita(id);
        }

        // POST: api/Visitas
        [HttpPost]
        public void Post([FromBody] Visita value)
        {
        }

        // PUT: api/Visitas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Visita value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
