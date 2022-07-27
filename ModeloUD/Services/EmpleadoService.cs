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
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "insert into empleado(idempleado, idcurso, idtipo, idsede, numeroidentidad, nombreempleado,apellidoempleado)" +
                        "values('"+empleado.Id+"','123',"+empleado.Rol+"','"+empleado.Sede+"','"+empleado.Codigo+"','"+empleado.Nombre+"','"+empleado.Apellido+"')";
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteEmpleado(int id)
        {
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "delete from empleado where idempleado=" + id;
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
            return true;
        }

        public Empleado GetEmpleado(int id)
        {
            Empleado empleado = new Empleado();
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from empleado where idtipo='" + id + "'";
                    OracleDataReader dataReader = oracleCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        empleado.Id = dataReader["idempleado"].ToString();
                        empleado.Rol = dataReader["idtipo"].ToString();
                        empleado.Sede = dataReader["idsede"].ToString();
                        empleado.Codigo = Convert.ToInt32(dataReader["numeroidentidad"]);
                        empleado.Nombre = dataReader["nombreempleado"].ToString();
                        empleado.Apellido = dataReader["apellidoempleado"].ToString();
                    }
                }
            }
            return empleado;
        }

        public IEnumerable<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from empleado";
                    OracleDataReader dataReader = oracleCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        empleados.Add(new Empleado
                        {
                            Id = dataReader["idempleado"].ToString(),
                            Rol = dataReader["idtipo"].ToString(),
                            Sede = dataReader["idsede"].ToString(),
                            Codigo = Convert.ToInt32(dataReader["numeroidentidad"]),
                            Nombre = dataReader["nombreempleado"].ToString(),
                            Apellido = dataReader["apellidoempleado"].ToString()
                        });
                    }
                }
            }
            return empleados;
        }

        public bool UpdateEmpleado(Empleado empleado)
        {
            using (OracleConnection con = new OracleConnection(_conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    /*con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "update empleado set desctipo='" + empleado.Descripcion + "'" + " where idtipo='" + empleado.Id + "'";
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();*/
                }
            }
            return true;
        }
    }
}
