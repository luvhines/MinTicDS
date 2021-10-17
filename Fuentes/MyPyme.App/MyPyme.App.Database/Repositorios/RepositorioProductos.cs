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
    public class RepositorioProductos : IRepositorioProductos
    {
        private string CadenaDeConexion;
        public RepositorioProductos(string cadenaDeConexion)
        {
            CadenaDeConexion = cadenaDeConexion;
        }

        protected SqlConnection Dbconexion()
        {
            return new SqlConnection(CadenaDeConexion);
        }

        public async Task<IEnumerable<Producto>> GetListaProductos()
        {
            var db = Dbconexion();

            var sql = @"SELECT * FROM [dbo].[tb_producto]";

            return await db.QueryAsync<Producto>(sql.ToString(), new { });
        }

        public async Task<Producto> GetProducto(int Id)
        {
            var db = Dbconexion();

            var sql = @"SELECT *
                        FROM [dbo].[tb_producto] 
                        WHERE Id = @Id";

            return await db.QueryFirstOrDefaultAsync<Producto>(sql.ToString(), new { Id });
        }

        public async Task<bool> GuardarProducto(Producto producto)
        {
            var db = Dbconexion();

            var sql = @"INSERT INTO [dbo].[tb_producto] (pro_nombre, pro_codigo, pro_valor_unitario, pro_cantidad)
                        VALUES(@pro_nombre, @pro_codigo, @pro_valor_unitario, @pro_cantidad)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new {producto.pro_nombre, producto.pro_codigo, producto.pro_valor_unitario, producto.pro_cantidad});

            return result > 0;
        }

        public async Task<bool> ModificarProducto(Producto producto)
        {
            var db = Dbconexion();

            var sql = @"UPDATE [dbo].[tb_producto]
                        SET
                            [pro_nombre] = @pro_nombre,
                            [pro_codigo] = @pro_codigo,
                            [pro_valor_unitario] = @pro_valor_unitario,
                            [pro_cantidad] = @pro_cantidad

                        WHERE [Id] = @Id
                        ";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { producto.pro_nombre, producto.pro_codigo, producto.pro_valor_unitario, producto.pro_cantidad, producto.Id});

            return result > 0;
        }
        public async Task<bool> EliminarProducto(int Id)
        {
            var db = Dbconexion();

            var sql = @"DELETE FROM [dbo].[tb_producto] 
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql.ToString(),new { Id });

            return result > 0;
        }
    }
}