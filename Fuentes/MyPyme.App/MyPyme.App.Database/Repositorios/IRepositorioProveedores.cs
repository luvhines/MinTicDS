using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Database.Repositorios
{
    public interface IRepositorioProveedores
    {
        Task<IEnumerable<Proveedor>> GetListaProveedores();
        Task<Proveedor> GetProveedor(int Id);
        Task<bool> GuardarProveedor(Proveedor proveedor);
        Task<bool> ModificarProveedor(Proveedor proveedor);
        Task<bool> EliminarProveedor(int Id);
    }
}