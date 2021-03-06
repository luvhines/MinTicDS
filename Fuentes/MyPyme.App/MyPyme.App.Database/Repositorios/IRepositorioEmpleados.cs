using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Database.Repositorios
{
    public interface IRepositorioEmpleados
    {
        Task<IEnumerable<Empleado>> GetListaEmpleados();
        Task<Empleado> GetEmpleado(int Id);
        Task<bool> GuardarEmpleado(Empleado empleado);
        Task<bool> ModificarEmpleado(Empleado empleado);
        Task<bool> EliminarEmpleado(int Id);
    }
}