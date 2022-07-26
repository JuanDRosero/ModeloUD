using ModeloUD.Interfaces;
using ModeloUD.Models;

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
            throw new NotImplementedException();
        }

        public bool DeleteSede(int id)
        {
            throw new NotImplementedException();
        }

        public Sede GetSede(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sede> GetSedes()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSede(Sede sede)
        {
            throw new NotImplementedException();
        }
    }
}
