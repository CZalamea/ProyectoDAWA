using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDAW.Models
{
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        [ForeignKey("CarritoId")]
        public Carrito carrito { get; set; }
        public decimal subtotal { get; set; }
        public bool estado { get; set; }
    }
}
