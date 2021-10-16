using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Ui.Interfaces
{
    public interface IServicioProveedor
    {
        Task<IEnumerable<Proveedor>> GetListaProveedores();
        Task<Proveedor> GetProveedor(int Id);
        Task<bool> GuardarProveedor(Proveedor proveedor);
        Task<bool> EliminarProveedor(int Id);
    }
}