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
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
        }

        public bool DeleteRol(int id)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return true;
        }

        public Rol GetRol(int id)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return new Rol();
        }

        public IEnumerable<Rol> GetRoles()
        {
            List<Rol> roles = new List<Rol>();
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return roles;
        }

        public bool UpdateRol(Rol empleado)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return true;
        }
    }
}
