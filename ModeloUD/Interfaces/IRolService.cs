using ModeloUD.Models;

namespace ModeloUD.Interfaces
{
    public interface IRolService
    {
        IEnumerable<Rol> GetRoles();
        Rol GetRol(int id);
        void AddRol(Rol empleado);
        bool UpdateRol(Rol empleado);
        bool DeleteRol(int id);
    }
}
