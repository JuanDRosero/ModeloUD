using ModeloUD.Interfaces;
using ModeloUD.Models;
using Oracle.ManagedDataAccess.Client;

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
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
        }

        public bool DeleteEmpleado(int id)
        {
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return true;
        }

        public Empleado GetEmpleado(int id)
        {
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return new Empleado();
        }

        public IEnumerable<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return empleados;
        }

        public bool UpdateEmpleado(Empleado empleado)
        {
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return true;
        }
    }
}
