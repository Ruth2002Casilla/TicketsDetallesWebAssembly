using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModels.Models
{
    public class Sistema
    {
        [Key]
        public int SistemaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Por favor, introduce un Nombre válido")]
        public string? Nombre { get; set; }
    }
}
