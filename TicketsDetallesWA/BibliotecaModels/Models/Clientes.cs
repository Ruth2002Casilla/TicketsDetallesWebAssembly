using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModels.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Por favor, introduce un Nombre válido")]
        public string? NombreCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Por favor, introduce un número de Teléfono válido")]
        [Range(0, int.MaxValue, ErrorMessage = "El número de Teléfono no puede ser negativo")]
        public int TelefonoCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Por favor, introduce un número de Celular válido")]
        [Range(0, int.MaxValue, ErrorMessage = "El número del Celular no puede ser negativo")]
        public int CelularCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Por favor, introduce un RNC válido")]
        public string? RNCCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "Por favor, introduce un Correo Electrónico válido")]
        public string? EmailCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9\s]*$", ErrorMessage = "Por favor, introduce una Dirección válida")]
        public string? DireccionCliente { get; set; }
    }
}
