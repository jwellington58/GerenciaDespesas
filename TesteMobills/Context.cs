using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMobills.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
           

        //    string connection = "Server=localhost; Database=TesteMobills; User Id=sa; Password=root;";

        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(connection);
        //    }
        //}

        public virtual DbSet<Despesa> Despesa {get;set;}
        public virtual DbSet<Receita> Receita { get; set; }
    }
}
