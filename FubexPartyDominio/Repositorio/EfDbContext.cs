using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FubexPartyDominio.Entidades;

namespace FubexPartyDominio.Repositorio
{
    class EfDbContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention
            >();
    }
}
