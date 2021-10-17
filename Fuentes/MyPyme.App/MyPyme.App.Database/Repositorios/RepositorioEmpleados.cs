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
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        private string CadenaDeConexion;
        public RepositorioEmpleados(string cadenaDeConexion)
        {
            CadenaDeConexion = cadenaDeConexion;
        }

        protected SqlConnection Dbconexion()
        {
            return new SqlConnection(CadenaDeConexion);
        }

        public async Task<IEnumerable<Empleado>> GetListaEmpleados()
        {
            var db = Dbconexion();

            var sql = @"SELECT * FROM [dbo].[tb_empleado]";

            return await db.QueryAsync<Empleado>(sql.ToString(), new { });
        }

        public async Task<Empleado> GetEmpleado(int Id)
        {
            var db = Dbconexion();

            var sql = @"SELECT *
                        FROM [dbo].[tb_empleado] 
                        WHERE Id = @Id";

            return await db.QueryFirstOrDefaultAsync<Empleado>(sql.ToString(), new { Id });
        }

        public async Task<bool> GuardarEmpleado(Empleado empleado)
        {
            var db = Dbconexion();

            var sql = @"INSERT INTO [dbo].[tb_empleado] (emd_nombre, emd_apellido, emd_direccion,
                        emd_celular, emd_correo, emd_cedula, emd_genero, emd_eps, emd_arl, emd_salario)
                        VALUES(@emd_nombre, @emd_apellido, @emd_direccion,
                        @emd_celular, @emd_correo, @emd_cedula, @emd_genero, @emd_eps, @emd_arl, @emd_salario)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new {empleado.emd_nombre, empleado.emd_apellido, empleado.emd_direccion, empleado.emd_celular, empleado.emd_correo, empleado.emd_cedula, empleado.emd_genero, empleado.emd_eps, empleado.emd_arl, empleado.emd_salario });

            return result > 0;
        }

        public async Task<bool> ModificarEmpleado(Empleado empleado)
        {
            var db = Dbconexion();

            var sql = @"UPDATE [dbo].[tb_empleado]
                        SET
                            [emd_nombre] = @emd_nombre,
                            [emd_apellido] = @emd_apellido,
                            [emd_direccion] = @emd_direccion,
                            [emd_celular] = @emd_celular,
                            [emd_correo] = @emd_correo,
                            [emd_cedula] = @emd_cedula,
                            [emd_genero] = @emd_genero,
                            [emd_eps] = @emd_eps,
                            [emd_arl] = @emd_arl,
                            [emd_salario] = @emd_salario

                        WHERE [Id] = @Id
                        ";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { empleado.emd_nombre, empleado.emd_apellido, empleado.emd_direccion,empleado.emd_celular, empleado.emd_correo, empleado.emd_cedula, empleado.emd_genero, empleado.emd_eps, empleado.emd_arl, empleado.emd_salario, empleado.Id});

            return result > 0;
        }
        public async Task<bool> EliminarEmpleado(int Id)
        {
            var db = Dbconexion();

            var sql = @"DELETE FROM [dbo].[tb_empleado] 
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql.ToString(),new { Id });

            return result > 0;
        }
    }
}