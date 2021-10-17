using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class Empleado
    {
        public int Id { get; set; }
        public string emd_nombre { get; set; }
        public string emd_apellido { get; set; }
        public string emd_direccion { get; set; }
        public string emd_celular { get; set; }
        public string emd_correo { get; set; }      
        public string emd_cedula { get; set; }
        public string emd_genero { get; set; }
        public string emd_eps { get; set; }
        public string emd_arl { get; set; }
        public double emd_salario { get; set; }

    }
}