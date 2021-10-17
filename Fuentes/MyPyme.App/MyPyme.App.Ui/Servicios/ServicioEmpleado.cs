using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using MyPyme.App.Model.Clases;
using MyPyme.App.Database.Repositorios;
using MyPyme.App.Ui.Interfaces;
using MyPyme.App.Ui.Data;

using MyPyme.App.Model.Clases;


namespace MyPyme.App.Ui.Servicios
{
    public class ServicioEmpleado : IServicioEmpleado
    {
        private readonly ConfiguracionSql _configuracionSql;
        private IRepositorioEmpleados _repositorioEmpleados;

        public ServicioEmpleado(ConfiguracionSql configuracionSql)
        {
            _configuracionSql = configuracionSql;
            _repositorioEmpleados = new RepositorioEmpleados(configuracionSql.CadenaDeConexion);
        }

        public Task<IEnumerable<Empleado>> GetListaEmpleados()
        {
            return _repositorioEmpleados.GetListaEmpleados();
        }

        public Task<Empleado> GetEmpleado(int Id)
        {
            return _repositorioEmpleados.GetEmpleado(Id);
        }

        public Task<bool> GuardarEmpleado(Empleado empleado)
        {
           if (empleado.Id == 0)
           {
               return _repositorioEmpleados.GuardarEmpleado(empleado);
           }
           else
           {
               return _repositorioEmpleados.ModificarEmpleado(empleado);
           } 
        }

        public Task<bool> EliminarEmpleado(int Id)
        {
            return _repositorioEmpleados.EliminarEmpleado(Id);
        }
    }
}