using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigracionesCelular.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionesCelular.Percistencia.Configuracion
{
    public class CelularConfiguracion
    {
         public CelularConfiguracion(EntityTypeBuilder<Celular> entityBuilder)
        {
            entityBuilder.Property(x => x.Marca).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Modelo).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Color).IsRequired().HasMaxLength(30);


            entityBuilder.HasData(
                new Celular
                {
                    CelularId = 1,
                    Marca = "SAMSUNG",
                    Modelo = "ASP20",
                    Color = "Negro"
                }
            );
        }
    }
}
