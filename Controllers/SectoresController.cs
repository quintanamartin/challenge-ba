using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examen_ba.DataAccess;
using examen_ba.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace examen_ba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectoresController : ControllerBase
    {
        private SectoresRepository _repo;
        public SectoresController(SectoresRepository repo)
        {
            _repo = repo;
        }
        // GET: api/Sectores
        [HttpGet]
        public ActionResult<List<Sector>> Get()
        {
            return _repo.GetSectores();
        }

        // GET: api/Sectores/5
        [HttpGet("{id}")]
        public ActionResult<Sector> Get(int id)
        {
            return _repo.GetSectores().First();
        }

        // POST: api/Sectores
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Sectores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
