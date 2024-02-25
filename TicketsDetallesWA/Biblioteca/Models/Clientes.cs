using System.ComponentModel.DataAnnotations;

namespace BibliotecaModels.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [RegularExpression(@"^[A-ZÁÉÍÓÚÑ][a-zA-ZÁÉÍÓÚÑ ]*$", ErrorMessage = "El Nombre debe comenzar con una letra mayúscula y no debe contener números.")]
        public string NombreCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1000000000, 2147483647, ErrorMessage = "El Teléfono debe tener 10 números y no puede ser negativo")]
        public int TelefonoCliente { get; set; }


        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [Range(1000000000, 2147483647, ErrorMessage = "El Celular debe tener 10 números y no puede ser negativo")]
        public string CelularCliente { get; set; }


        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string RNCCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Por favor, ingresa un correo electrónico válido")]
        public string EmailCliente { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9\s]*$", ErrorMessage = "La Dirección debe comenzar con una letra mayúscula")]
        public string DireccionCliente { get; set; }
    }
}
