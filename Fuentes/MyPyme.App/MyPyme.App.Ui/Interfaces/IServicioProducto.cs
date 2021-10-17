using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Ui.Interfaces
{
    public interface IServicioProducto
    {
        Task<IEnumerable<Producto>> GetListaProductos();
        Task<Producto> GetProducto(int Id);
        Task<bool> GuardarProducto(Producto producto);
        Task<bool> EliminarProducto(int Id);
    }
}