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
    public class ServicioCliente : IServicioCliente
    {

        private readonly ConfiguracionSql _configuracionSql;
        private IRepositorioClientes _repositorioClientes;

        public ServicioCliente(ConfiguracionSql configuracionSql)
        {
            _configuracionSql = configuracionSql;
            _repositorioClientes = new RepositorioClientes(configuracionSql.CadenaDeConexion);
        }

        public Task<IEnumerable<Cliente>> GetListaClientes()
        {
            return _repositorioClientes.GetListaClientes();
        }

        public Task<Cliente> GetCliente(int Id)
        {
            return _repositorioClientes.GetCliente(Id);
        }

        public Task<bool> GuardarCliente(Cliente cliente)
        {
           if (cliente.Id == 0)
           {
               return _repositorioClientes.GuardarCliente(cliente);
           }
           else
           {
               return _repositorioClientes.ModificarCliente(cliente);
           } 
        }

        public Task<bool> EliminarCliente(int Id)
        {
            return _repositorioClientes.EliminarCliente(Id);
        }
    }
}