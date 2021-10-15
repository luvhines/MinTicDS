using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double ValorUnitario { get; set; }
        public int Cantidad { get; set; }

    }
}