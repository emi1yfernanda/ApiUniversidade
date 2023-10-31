using System;
using Apiuniversidade.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apiuniversidade.Context;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;


namespace Apiuniversidade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase  
    {
        
        [HttpGet]
        public ActionResult <IEnumerable <Curso>> Get()
        {
            var cursos = _context.Curso.ToList();
            if(cursos is null)
                return NotFound();

                return cursos;
        }

        [HttpPost]
        public ActionResult Post(Curso curso){
            _context.Curso.Add(curso);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCurso",
                new { id = curso.id},
                curso);

        }

        [HttpGet("{id:int}", Name = "GetCurso")]
        public ActionResult<Curso> Get1(int id)
        {
            var curso = _context.Curso.FirstOrDefault(p => p.Id == id);
            if (curso is null)
                return NotFound("Curso não encontrado");

            return curso;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Curso curso)
        {
            if(id != curso.Id)
                return BadRequest();

            _context.Entry(curso).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(curso);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var curso = _context.Curso.FirstOrDefault(p => p.Id == id);

            if (curso is null)
                return NotFound();

            _context.Curso.Remove(curso);
            _context.SaveChanges();

            return Ok(curso);
        }

        private readonly ILogger<CursoController>_logger;

        private readonly ApiuniversidadeContext _context;

        public CursoController(ILogger<CursoController> logger, ApiuniversidadeContext context)
        {
            _logger = logger;
            _context = _context;
        }

    }
}





// [HttpGet(Name = "cursos")]
       // public List<Curso> GetCursos(){
           // List<Curso> cursos = new List<Curso>();

        //    Curso c1 = new Curso();
       //     c1.nome = "Informática";
         //   c1.area = "Computação";
         //   c1.duracao = 50;
            //c1.Alunos = Aluno;

         //   Curso c2 = new Curso();
        //    c2.nome = "Eletronica";
         //   c2.area = "Computação";
         //   c2.duracao = 60;

          //  Curso c3 = new Curso();
          //  c3.nome = "Sistemas para intenet";
          //  c3.area = "Computação";
         //   c3.duracao = 50;

          //  cursos.Add(c1);
          //  cursos.Add(c2);
          //  cursos.Add(c3);

          //  return cursos;