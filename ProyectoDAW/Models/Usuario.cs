using System.ComponentModel.DataAnnotations;

namespace ProyectoDAW.Models
{
    public class Usuario
    {
        [Key]
        public string UsuarioId { get; set; }
        public string UsuarioNombre { get; set;}
        public string UsuarioApellido { get; set;}
        [Required]
        [EmailAddress]
        [MaxLength(254)]
        public string UsuarioEmail { get; set; }
        public string UsuarioPassword { get; set; }
        public string UsuarioDireccion { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string UsuarioTelefono { get; set; }
        public bool UsuarioEstado { get; set; }
    }
}
