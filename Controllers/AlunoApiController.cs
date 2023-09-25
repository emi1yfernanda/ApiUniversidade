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
    public class AlunoApiController : ControllerBase
    {
        [HttpGet(Name = "Alunos")]
        public List<Aluno> GetAlunos(){
            List<Aluno> alunos = new List<Aluno>();

            Aluno a1 = new Aluno();
            a1.CPF = "17343627347";
            a1.Nome = "EMILY";
            a1.DataNascimento = DateTime.Now;

            alunos.Add(a1);
            return alunos;
        }
        
    }
}