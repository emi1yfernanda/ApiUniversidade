using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apiuniversidade.Model;

namespace Apiuniversidade.Context
{
    public class ApiuniversidadeContext : DbContext
    {
        internal object cursos;

        public ApiuniversidadeContext(DbContextOptions options) : base(options){}
        // DbContextOptions é uma clase auxiliar para tranportar informações de configurações de acesso ao banco.
        
        public DbSet<Aluno>? Aluno {  get; set; }
        public DbSet<Curso>? Curso {  get; set; }
        public DbSet<Disciplina>? Disciplina {  get; set; }
          
    }
}