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
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.CommandText = "Insert into yeserranon.empleado(IDEMPLEADO, IDCURSO, IDTIPO, IDSEDE, NUMEROIDENTIDAD, " +
                        "NOMBREEMPLEADO, APELLIDOEMPLEADO)Values("+empleado.Id+"','"+"'123'"+empleado.Rol+"','"+empleado.Sede
                        +"','"+empleado.Codigo+"','"+empleado.Nombre+"','"+empleado.Apellido+"')'";
                    oracleCommand.ExecuteNonQuery();
                }
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
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from empleado;";
                    OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        Empleado empleado = new Empleado
                        {
                            Id = oracleDataReader["idEmpleado"].ToString(),
                            Codigo = Convert.ToInt32(oracleDataReader["numeroEmpleado"]),
                            Nombre = oracleDataReader["nombre"].ToString(),
                            Apellido = oracleDataReader["apellido"].ToString(),
                            Rol = oracleDataReader["rol"].ToString(),
                            Sede = oracleDataReader["sede"].ToString()
                            
                        };
                    }
                }
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
