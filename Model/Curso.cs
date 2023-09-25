using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apiuniversidade.Model
{
    public class Curso
    {
        public int id {get; set;} 
        public string nome {get; set;}
        public string area {get; set;}
        public int duracao {get; set;}
        
        public List<Disciplina> disciplinas {get; set;}
        public List<Aluno> Alunos {get; set;}

        public Curso(){
            disciplinas = new List<Disciplina>();
        }
        
    }
}