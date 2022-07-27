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
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "INSERT INTO SEDE (IDSEDE, NOMBRESEDE) VALUES ('"+sede.Id+"','"+sede.Nombre+"')";
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteSede(int id)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "delete from sede where idsede="+id;
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
            return true;
        }

        public Sede GetSede(int id)
        {
            Sede sede = new Sede();
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from sede where idsede='"+id+"'";
                    OracleDataReader dataReader = oracleCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        sede.Id = dataReader["idsede"].ToString();
                        sede.Nombre = dataReader["nombresede"].ToString();   
                    }
                }
            }
            return sede;
        }

        public IEnumerable<Sede> GetSedes()
        {
            List<Sede> sedes = new List<Sede>();
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.BindByName = true;
                    oracleCommand.CommandText = "select * from sede";
                    OracleDataReader dataReader = oracleCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        sedes.Add(new Sede
                        {
                            Id = dataReader["idsede"].ToString(),
                            Nombre = dataReader["nombresede"].ToString(),
                        });
                    }
                }
            }
            return sedes;
        }

        public bool UpdateSede(Sede sede)
        {
            using (OracleConnection con = new OracleConnection(conexionString))
            {
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    con.Open();
                    oracleCommand.Connection = con;
                    oracleCommand.CommandText = "update sede set nombresede='"+sede.Nombre+"'"+" where idsede='"+sede.Id+"'";
                    oracleCommand.CommandType = System.Data.CommandType.Text;
                    oracleCommand.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
