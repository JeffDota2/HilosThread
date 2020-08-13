using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionesCelular.Entidades
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public string ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public List<FacturaDetalles> Producto { get; set; }
    }
}
