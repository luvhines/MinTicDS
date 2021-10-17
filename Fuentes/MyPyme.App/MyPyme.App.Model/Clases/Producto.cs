using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class Producto
    {
        public int Id { get; set; }
        public string pro_nombre { get; set; }
        public string pro_codigo { get; set; }
        public double pro_valor_unitario { get; set; }
        public int pro_cantidad { get; set; }

    }
}