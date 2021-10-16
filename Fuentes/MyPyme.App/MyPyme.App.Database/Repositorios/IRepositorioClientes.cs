using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Database.Repositorios
{
    public interface IRepositorioClientes
    {
        Task<IEnumerable<Cliente>> GetListaClientes();
        Task<Cliente> GetCliente(int Id);
        Task<bool> GuardarCliente(Cliente cliente);
        Task<bool> ModificarCliente(Cliente cliente);
        Task<bool> EliminarCliente(int Id);
    }
}