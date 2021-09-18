using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Database
{
    public partial class MuzickaListaContext:DbContext
    {
        public MuzickaListaContext(DbContextOptions<MuzickaListaContext> options)
            : base(options)
        { }

        public DbSet<Pjesme> Pjesme { get; set; }
        public DbSet<Kategorije> Kategorije { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
