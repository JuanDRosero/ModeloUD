using ModeloUD.Models;

namespace ModeloUD.Interfaces
{
    public interface ISedeService
    {
        IEnumerable<Sede> GetSedes();
        Sede GetSede(int id);
        void AddSede(Sede sede);
        bool UpdateSede(Sede sede);
        bool DeleteSede(int id);
    }
}
