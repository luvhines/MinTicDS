using System.Runtime.Intrinsics.X86;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

using MyPyme.App.Model.Clases;


namespace MyPyme.App.Database.Repositorios
{
    public class RepositorioPqrs : IRepositorioPqrs
    {
        private string CadenaDeConexion;
        public RepositorioPqrs(string cadenaDeConexion)
        {
            CadenaDeConexion = cadenaDeConexion;
        }

        protected SqlConnection Dbconexion()
        {
            return new SqlConnection(CadenaDeConexion);
        }

        public async Task<IEnumerable<Pqrs>> GetListaPqrs()
        {
            throw new NotImplementedException(); 
        }

        public async Task<Pqrs> GetPqrs(int Id)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> GuardarPqrs(Pqrs Pqrs)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> ModificarPqrs(Pqrs Pqrs)
        {
            throw new NotImplementedException();

        }
        public async Task<bool> EliminarPqrs(int Id)
        {
            throw new NotImplementedException();

        }
    }
}