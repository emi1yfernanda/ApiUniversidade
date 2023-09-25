using System;
using Apiuniversidade.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Apiuniversidade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        [HttpGet(Name = "cursos")]
        public List<Curso> GetCursos(){
            List<Curso> cursos = new List<Curso>();

            Curso c1 = new Curso();
            c1.nome = "Informática";
            c1.area = "Computação";
            c1.duracao = 50;
            //c1.Alunos = Aluno;

            Curso c2 = new Curso();
            c2.nome = "Eletronica";
            c2.area = "Computação";
            c2.duracao = 60;

            Curso c3 = new Curso();
            c3.nome = "Sistemas para intenet";
            c3.area = "Computação";
            c3.duracao = 50;

            cursos.Add(c1);
            cursos.Add(c2);
            cursos.Add(c3);

            return cursos;


        }
    }
}