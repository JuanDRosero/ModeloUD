using System.ComponentModel.DataAnnotations;

namespace ModeloUD.Models
{
    public class Empleado
    {
        [Required(ErrorMessage="Se requiere el campo ID")]
        [StringLength(3)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Se requiere el campo Codigo")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Se requiere el campo Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requiere el campo Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Se requiere el campo rol")]
        public string Rol { get; set; } //El PK del rol
        [Required(ErrorMessage = "Se requiere el campo Sede")]
        public string Sede { get; set; } //El PK del Sede

    }
}
