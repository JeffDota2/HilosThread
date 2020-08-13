namespace MigracionesCelular.Entidades
{
    public class FacturaDetalles
    {
        public int FacturaDetallesId { get; set; }
        public int FacturaId { get; set; }

        public Factura Factura { get; set; }

        public int ProductoId { get; set; }

        public int Producto { get; set; }

        public int Precio { get; set; }

        public int SubTotal { get; set; }

        public int Cantidad { get; set; }




    }
}