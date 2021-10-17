using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Ui.Interfaces
{
    public interface IServicioEmpleado
    {
        Task<IEnumerable<Empleado>> GetListaEmpleados();
        Task<Empleado> GetEmpleado(int Id);
        Task<bool> GuardarEmpleado(Empleado empleado);
        Task<bool> EliminarEmpleado(int Id);
    }
}