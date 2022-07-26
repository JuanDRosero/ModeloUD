using ModeloUD.Interfaces;
using ModeloUD.Models;
using Oracle.ManagedDataAccess.Client;

namespace ModeloUD.Services
{
    public class SedeService : ISedeService
    {
        private string conexionString;

        public SedeService(IConfiguration configuration)
        {
            conexionString = configuration.GetConnectionString("OracleDBConnection");
        }

        public void AddSede(Sede sede)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.CommandText = "INSERT INTO SEDE (IDSEDE, NOMBRESEDE) VALUES ('"+sede.Id+"','"+sede.Nombre+"');";
                    oracleCommand.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteSede(int id)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return true;
        }

        public Sede GetSede(int id)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return new Sede();
        }

        public IEnumerable<Sede> GetSedes()
        {
            List<Sede> sedes = new List<Sede>();
            using (OracleConnection con = new OracleConnection(conexionString))
            {
            //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return sedes;
        }

        public bool UpdateSede(Sede sede)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                //https://www.youtube.com/watch?v=Gix8F1FUGeo min 250
            }
            return true;
        }
    }
}
