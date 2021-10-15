using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }      
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public string Eps { get; set; }
        public string Arl { get; set; }
        public double Salario { get; set; }

    }
}