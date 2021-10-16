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

        public async Task<IEnumerable<Cliente>> GetListaClientes()
        {
            var db = Dbconexion();

            var sql = @"SELECT Id ,cli_nombre, cli_cedula, cli_correo FROM [dbo].[tb_cliente]";

            return await db.QueryAsync<Cliente>(sql.ToString(), new { });
        }

        public async Task<Cliente> GetCliente(int Id)
        {
            var db = Dbconexion();

            var sql = @"SELECT Id ,cli_nombre, cli_cedula, cli_correo 
                        FROM [dbo].[tb_cliente] 
                        WHERE Id = @Id";

            return await db.QueryFirstOrDefaultAsync<Cliente>(sql.ToString(), new { Id });
        }

        public async Task<bool> GuardarCliente(Cliente cliente)
        {
            var db = Dbconexion();

            var sql = @"INSERT INTO [dbo].[tb_cliente] ([cli_nombre],[cli_cedula],[cli_correo])
                        VALUES(@cli_nombre, @cli_cedula, @cli_correo)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { cliente.cli_nombre, cliente.cli_cedula, cliente.cli_correo });

            return result > 0;
        }

        public async Task<bool> ModificarCliente(Cliente cliente)
        {
            var db = Dbconexion();

            var sql = @"UPDATE [dbo].[tb_cliente]
                        SET
                            [cli_nombre] = @cli_nombre,
                            [cli_cedula] = @cli_cedula,
                            [cli_correo] = @cli_correo
                        WHERE [Id] = @Id
                        ";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { cliente.cli_nombre, cliente.cli_cedula, cliente.cli_correo, cliente.Id });

            return result > 0;
        }
        public async Task<bool> EliminarCliente(int Id)
        {
            var db = Dbconexion();

            var sql = @"DELETE FROM [dbo].[tb_cliente] 
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql.ToString(),new { Id });

            return result > 0;
        }
    }
}