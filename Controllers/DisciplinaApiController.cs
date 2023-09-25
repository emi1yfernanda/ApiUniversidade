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
    public class DisciplinaApiController : ControllerBase
    {
        [HttpGet(Name= "disciplinas")]
        public List<Disciplina> GetDisciplina(){
            List<Disciplina> disciplinas = new List<Disciplina>();

            Disciplina d = new Disciplina();
            d.nome = "Programação para Internet";
            d.CargaHoraria = 60;
            d.semestre = 8;

            Disciplina d1 = new Disciplina();
            d1.nome = "Projeto de vida";
            d1.CargaHoraria = 60;
            d1.semestre = 6;

            Disciplina d2 = new Disciplina();
            d2.nome = "Programação web";
            d2.CargaHoraria = 60;
            d2.semestre = 5;

            disciplinas.Add(d);
            disciplinas.Add(d1);
            disciplinas.Add(d2);
                    
            return disciplinas;             
        }
    }
}