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
    public class RepositorioProveedores : IRepositorioProveedores
    {
        
        private string CadenaDeConexion;
        public RepositorioProveedores(string cadenaDeConexion)
        {
            CadenaDeConexion = cadenaDeConexion;
        }

        protected SqlConnection Dbconexion()
        {
            return new SqlConnection(CadenaDeConexion);
        }

        public async Task<IEnumerable<Proveedor>> GetListaProveedores()
        {
            var db = Dbconexion();

            var sql = @"SELECT [Id],[pvd_nit],[pvd_nombre],[pvd_telefono],[pvd_direccion],[pvd_correo] 
                        FROM [dbo].[tb_proveedor]";

            return await db.QueryAsync<Proveedor>(sql.ToString(), new { });
        }

        public async Task<Proveedor> GetProveedor(int Id)
        {
            var db = Dbconexion();

            var sql = @"SELECT [Id],[pvd_nit],[pvd_nombre],[pvd_telefono],[pvd_direccion],[pvd_correo] 
                        FROM [dbo].[tb_proveedor] 
                        WHERE Id = @Id";

            return await db.QueryFirstOrDefaultAsync<Proveedor>(sql.ToString(), new { Id });
        }

        public async Task<bool> GuardarProveedor(Proveedor proveedor)
        {
            var db = Dbconexion();

            var sql = @"INSERT INTO [dbo].[tb_proveedor] ([pvd_nit],[pvd_nombre],[pvd_telefono],[pvd_direccion],[pvd_correo])
                        VALUES(@pvd_nit, @pvd_nombre ,@pvd_telefono, @pvd_direccion, @pvd_correo)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { proveedor.pvd_nit, proveedor.pvd_nombre, proveedor.pvd_telefono, proveedor.pvd_direccion, proveedor.pvd_correo });

            return result > 0;
        }

        public async Task<bool> ModificarProveedor(Proveedor proveedor)
        {
            var db = Dbconexion();

            var sql = @"UPDATE [dbo].[tb_proveedor]
                        SET
                            [pvd_nit] = @pvd_nit,
                            [pvd_nombre] = @pvd_nombre,
                            [pvd_telefono] = @pvd_telefono,
                            [pvd_direccion] = @pvd_direccion,
                            [pvd_correo] = @pvd_correo
                        WHERE [Id] = @Id
                        ";

            var result = await db.ExecuteAsync(sql.ToString(),
                new {   proveedor.pvd_nit, proveedor.pvd_nombre, proveedor.pvd_telefono, 
                        proveedor.pvd_direccion, proveedor.pvd_correo, proveedor.Id });

            return result > 0;
        }
        public async Task<bool> EliminarProveedor(int Id)
        {
            var db = Dbconexion();

            var sql = @"DELETE FROM [dbo].[tb_proveedor] 
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql.ToString(),new { Id });

            return result > 0;
        }
    }
}