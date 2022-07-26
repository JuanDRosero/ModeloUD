using Microsoft.AspNetCore.Mvc.Rendering;

namespace ModeloUD.Models
{
    public class EmpleadoViewModel
    {
        public Empleado Empleado { get; set; }
        public SelectList listaSedes { get; set; }
        public SelectList listaRoles { get; set; }
    }
}
