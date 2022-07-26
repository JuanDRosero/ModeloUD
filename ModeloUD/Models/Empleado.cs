using System.ComponentModel.DataAnnotations;

namespace ModeloUD.Models
{
    public class Empleado
    {
        [Required(ErrorMessage="Se requiere el campo ID")]
        [StringLength(3)]
        public string Id { get; set; }
        /*
         * 
         * 
         * */

    }
}
