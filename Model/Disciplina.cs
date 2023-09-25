using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apiuniversidade.Model
{
    public class Disciplina
    {
        public int id {get; set;}
        public string nome {get; set;}
        public int CargaHoraria {get; set;}
        public int semestre {get; set;}
    }
}