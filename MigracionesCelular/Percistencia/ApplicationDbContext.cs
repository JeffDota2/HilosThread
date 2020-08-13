using Microsoft.EntityFrameworkCore;
using MigracionesCelular.Entidades;
using MigracionesCelular.Percistencia.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionesCelular.Percistencia
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalles> FacturaDetalles { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new ClienteConfiguracion(builder.Entity<Cliente>());
            new CelularConfiguracion(builder.Entity<Celular>());
            new FacturaConfiguracion(builder.Entity<Factura>());
            new FacturaDetallesConfiguracion(builder.Entity<FacturaDetalles>());

        }
    }
}
