using System.ComponentModel.DataAnnotations;

namespace ModeloUD.Models
{
    public class Rol
    {
        [Required(ErrorMessage="Se requiere el campo Id")]
        [StringLength(3)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Se requiere el campo Descripcion")]
        public string Descripcion { get; set; }
    }
}
