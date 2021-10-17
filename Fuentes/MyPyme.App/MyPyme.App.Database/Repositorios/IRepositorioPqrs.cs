using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;

namespace MyPyme.App.Database.Repositorios
{
    public interface IRepositorioPqrs
    {
        Task<IEnumerable<Pqrs>> GetListaPqrs();
        Task<Pqrs> GetPqrs(int Id);
        Task<bool> GuardarPqrs(Pqrs Pqrs);
        Task<bool> ModificarPqrs(Pqrs Pqrs);
        Task<bool> EliminarPqrs(int Id);
    }
}