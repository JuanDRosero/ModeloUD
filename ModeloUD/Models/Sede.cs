using System.ComponentModel.DataAnnotations;

namespace ModeloUD.Models
{
    public class Sede
    {
        [Required(ErrorMessage="Se requiere el campo Id")]
        [StringLength(3)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Se requiere el campo Nombre")]
        public string Nombre { get; set; }
    }
}
