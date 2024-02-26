using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModels.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Por favor, introduce una Descripciòn válida")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1, 31, ErrorMessage = "El valor debe estar entre (1 - 31)")]
        public int DiasCompromiso { get; set; }
    }
}
