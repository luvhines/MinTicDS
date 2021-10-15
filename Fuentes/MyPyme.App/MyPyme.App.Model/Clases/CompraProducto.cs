using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class CompraProducto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double Valor { get; set; }
        public double Iva { get; set; }
        public FacturaCompra FacturaCompra { get; set; }
        public Producto Producto { get; set; }

    }
}