using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class FacturaVenta
    {
        public int Id { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Total { get; set; }
        public Cliente Cliente { get; set; }
        public Empresa Empresa { get; set; }
        public Empleado Empleado { get; set; }
    }
}