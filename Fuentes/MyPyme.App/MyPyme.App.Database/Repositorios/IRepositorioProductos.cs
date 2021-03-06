using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Database.Repositorios
{
    public interface IRepositorioProductos
    {
        Task<IEnumerable<Producto>> GetListaProductos();
        Task<Producto> GetProducto(int Id);
        Task<bool> GuardarProducto(Producto pproducto);
        Task<bool> ModificarProducto(Producto producto);
        Task<bool> EliminarProducto(int Id);
    }
}