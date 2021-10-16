using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;
using MyPyme.App.Database.Repositorios;
using MyPyme.App.Ui.Interfaces;
using MyPyme.App.Ui.Data;


namespace MyPyme.App.Ui.Servicios
{
    public class ServicioProveedor : IServicioProveedor
    {
        private readonly ConfiguracionSql _configuracionSql;
        private IRepositorioProveedores _repositorioProveedores;

        public ServicioProveedor(ConfiguracionSql configuracionSql)
        {
            _configuracionSql = configuracionSql;
            _repositorioProveedores = new RepositorioProveedores(configuracionSql.CadenaDeConexion);
        }

        public Task<IEnumerable<Proveedor>> GetListaProveedores()
        {
            return _repositorioProveedores.GetListaProveedores();
        }

        public Task<Proveedor> GetProveedor(int Id)
        {
            return _repositorioProveedores.GetProveedor(Id);
        }

        public Task<bool> GuardarProveedor(Proveedor proveedor)
        {
           if (proveedor.Id == 0)
           {
               return _repositorioProveedores.GuardarProveedor(proveedor);
           }
           else
           {
               return _repositorioProveedores.ModificarProveedor(proveedor);
           } 
        }

        public Task<bool> EliminarProveedor(int Id)
        {
            return _repositorioProveedores.EliminarProveedor(Id);
        }
    }
}