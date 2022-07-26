using ModeloUD.Interfaces;
using ModeloUD.Models;

namespace ModeloUD.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly string _conexionString;
        public EmpleadoService(IConfiguration configuration)
        {
            _conexionString = configuration.GetConnectionString("OracleDBConnection");  //Obtención de la cadena de conexión
        }

        public void AddEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmpleado(int id)
        {
            throw new NotImplementedException();
        }

        public Empleado GetEmpleado(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> GetEmpleados()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}
