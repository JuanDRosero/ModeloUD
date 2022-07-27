using ModeloUD.Interfaces;
using ModeloUD.Models;
using Oracle.ManagedDataAccess.Client;

namespace ModeloUD.Services
{
    public class RolService : IRolService
    {
        private string conexionString;
        public RolService(IConfiguration configuration)
        {
            conexionString = configuration.GetConnectionString("OracleDBConnection");
        }
        public void AddRol(Rol empleado)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "INSERT INTO tipoempleado (idtipo, desctipo) VALUES ('" + empleado.Id + "','" + empleado.Descripcion + "')";
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteRol(int id)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "delete from tipoempleado where idtipo=" + id;
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
            return true;
        }

        public Rol GetRol(int id)
        {
            Rol rol = new Rol();
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from tipoempleado where idtipo='" + id + "'";
                    OracleDataReader dataReader = oracleCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        rol.Id = dataReader["idtipo"].ToString();
                        rol.Descripcion = dataReader["desctipo"].ToString();
                    }
                }
            }
            return rol;
        }

        public IEnumerable<Rol> GetRoles()
        {
            List<Rol> roles = new List<Rol>();
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from tipoempleado";
                    OracleDataReader dataReader = oracleCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        roles.Add(new Rol
                        {
                            Id = dataReader["idtipo"].ToString(),
                            Descripcion = dataReader["desctipo"].ToString(),
                        });
                    }
                }
            }
            return roles;
        }

        public bool UpdateRol(Rol empleado)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "update tipoempleado set desctipo='" + empleado.Descripcion + "'" + " where idtipo='" + empleado.Id + "'";
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
