using System;
using System.Text;
using System.Collections.Generic;

namespace MyPyme.App.Model.Clases
{
    public class Pqrs : Cliente
    {
        public int Id { get; set; }
        public string TipoReclamo { get; set; }
        public DateTime FechaRegistro { get; set; }
        
    }
}