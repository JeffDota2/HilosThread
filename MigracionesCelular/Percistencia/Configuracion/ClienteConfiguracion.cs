using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigracionesCelular.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionesCelular.Percistencia.Configuracion
{
    public class ClienteConfiguracion
    {
        public ClienteConfiguracion(EntityTypeBuilder<Cliente> entityBuilder)
        {
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Apellido).IsRequired().HasMaxLength(100);


            entityBuilder.HasData(
                new Cliente
                {
                    ClienteId = 1,
                    Nombre = "Gorky",
                    Apellido = "Estrella",
                }
            );
        }
    }
}
