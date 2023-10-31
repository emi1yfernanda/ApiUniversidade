using System;
using Apiuniversidade.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apiuniversidade.Context;
using Microsoft.EntityFrameworkCore;

namespace Apiuniversidade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisciplinaController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post(Disciplina disciplina){
            _context.Disciplina.Add(disciplina);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetDisciplina",
                new { id = disciplina.id},
                disciplina);

        }

        [HttpGet("{id:int}", Name = "GetDisciplina")]
        public ActionResult<Disciplina> Get1(int id)
        {
            var disciplina = _context.Disciplina.FirstOrDefault(p => p.id == id);
            if (disciplina is null)
                return NotFound("Disciplina não encontrada");

            return disciplina;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Disciplina disciplina)
        {
            if(id != disciplina.id)
                return BadRequest();

            _context.Entry(disciplina).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(disciplina);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var disciplina = _context.Disciplina.FirstOrDefault(p => p.id == id);

            if (disciplina is null)
                return NotFound();

            _context.Disciplina.Remove(disciplina);
            _context.SaveChanges();

            return Ok(disciplina);
        }

        
        
        private readonly ILogger<DisciplinaController>_logger;

        private readonly ApiuniversidadeContext _context;

        public DisciplinaController(ILogger<DisciplinaController> logger, ApiuniversidadeContext context)
        {
            _logger = logger;
            _context = _context;
        }
    }
}