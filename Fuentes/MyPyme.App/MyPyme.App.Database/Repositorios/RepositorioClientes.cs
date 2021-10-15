using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

using MyPyme.App.Model.Clases;


namespace MyPyme.App.Database.Repositorios
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private string CadenaDeConexion;
        public RepositorioClientes(string cadenaDeConexion)
        {
            CadenaDeConexion = cadenaDeConexion;
        }

        protected SqlConnection Dbconexion()
        {
            return new SqlConnection(CadenaDeConexion);
        }

        public Task<IEnumerable<Cliente>> GetListaClientes()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetCliente(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GuardarCliente(Cliente cliente)
        {
            var db = Dbconexion();

            var sql = @"INSERT INTO [dbo].[tb_cliente] ([cli_nombre],[cli_cedula],[cli_correo])
                        VALUES(@cli_nombre, @cli_cedula, @cli_correo)";

            var cli_nombre = cliente.Nombre;
            var cli_cedula = cliente.Cedula;
            var cli_correo = cliente.Correo;

            var result = await db.ExecuteAsync(sql.ToString(), 
                new {cli_nombre, cli_cedula, cli_correo});

            return result > 0;
        }

        public Task<bool> ModificarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public Task<bool> EliminarCliente(int Id)
        {
            throw new NotImplementedException();    
        }
    }
}