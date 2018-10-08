using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace fp_stack.core.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :
            base(options)
        {

        }

        public DbSet<Pergunta> Perguntas{ get; set; }
    }
}
