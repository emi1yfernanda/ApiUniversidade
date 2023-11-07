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
    public class AlunoController : ControllerBase
    {
        [HttpGet(Name = "Alunos")]
        public List<Aluno> GetAlunos(){
            List<Aluno> aluno = new List<Aluno>();

            Aluno a1 = new Aluno();
            a1.CPF = "17343627347";
            a1.Nome = "EMILY";
            a1.DataNascimento = DateTime.Now;

            aluno.Add(a1);
            return aluno;
        }

        [HttpPost]
        public ActionResult Post(Aluno aluno){
            _context.Aluno.Add(aluno);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetAluno",
                new { id = aluno.Id},
                aluno);

        }

        [HttpGet("{id:int}", Name = "GetAluno")]
        public ActionResult<Aluno> Get1(int id)
        {
            var aluno = _context.Aluno.FirstOrDefault(p => p.Id == id);
            if (aluno is null)
                return NotFound("Aluno não encontrado");

            return aluno;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Aluno aluno)
        {
            if(id != aluno.Id)
                return BadRequest();

            _context.Entry(aluno).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(aluno);
        }

        
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var aluno = _context.Aluno.FirstOrDefault(p => p.Id == id);

            if (aluno is null)
                return NotFound();

            _context.Aluno.Remove(aluno);
            _context.SaveChanges();

            return Ok(aluno);
        }

        private readonly ILogger<AlunoController>_logger;

        private readonly ApiuniversidadeContext _context;

        public AlunoController(ILogger<AlunoController> logger, ApiuniversidadeContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}