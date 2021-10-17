using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;
using MyPyme.App.Database.Repositorios;
using MyPyme.App.Ui.Interfaces;
using MyPyme.App.Ui.Data;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Ui.Servicios
{
    public class ServicioProducto : IServicioProducto
    {
        private readonly ConfiguracionSql _configuracionSql;
        private IRepositorioProductos _repositorioProductos;

        public ServicioProducto(ConfiguracionSql configuracionSql)
        {
            _configuracionSql = configuracionSql;
            _repositorioProductos = new RepositorioProductos(configuracionSql.CadenaDeConexion);
        }

        public Task<IEnumerable<Producto>> GetListaProductos()
        {
            return _repositorioProductos.GetListaProductos();
        }

        public Task<Producto> GetProducto(int Id)
        {
            return _repositorioProductos.GetProducto(Id);
        }

        public Task<bool> GuardarProducto(Producto producto)
        {
           if (producto.Id == 0)
           {
               return _repositorioProductos.GuardarProducto(producto);
           }
           else
           {
               return _repositorioProductos.ModificarProducto(producto);
           } 
        }

        public Task<bool> EliminarProducto(int Id)
        {
            return _repositorioProductos.EliminarProducto(Id);
        }
    }
}