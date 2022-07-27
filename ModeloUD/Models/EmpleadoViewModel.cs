using Microsoft.AspNetCore.Mvc.Rendering;

namespace ModeloUD.Models
{
    public class EmpleadoViewModel
    {
        public Empleado emp { get; set; }
        public List<SelectListItem> listaSedes { get; set; } = null;
        public List<SelectListItem> listaRoles { get; set; } = null;
    }
}
