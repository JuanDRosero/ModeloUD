using ModeloUD.Models;

namespace ModeloUD.Interfaces
{
    public interface IEmpleadoService
    {
         IEnumerable<Empleado> GetEmpleados();
        Empleado GetEmpleado(int id);
        void AddEmpleado(Empleado empleado);
        bool UpdateEmpleado(Empleado empleado);
        bool DeleteEmpleado(int id);

    }
}
