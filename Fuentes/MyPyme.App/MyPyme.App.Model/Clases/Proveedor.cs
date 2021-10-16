using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string pvd_nit { get; set; }
        public string pvd_nombre { get; set; }
        public string pvd_telefono { get; set; }
        public string pvd_direccion { get; set; }
        public string pvd_correo { get; set; }

    }
}