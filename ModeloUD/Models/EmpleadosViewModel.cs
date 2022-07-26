using Microsoft.AspNetCore.Mvc.Rendering;

namespace ModeloUD.Models
{
    public class EmpleadosViewModel
    {
        public IEnumerable<Empleado> Empleados { get; set; }
        public IEnumerable<Sede> listaSedes { get; set; }
        public IEnumerable<Rol> listaRoles { get; set; }
    }
}
