using ProyectoDAW.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDAW.Models
{
    public class Carrito
    {
        [Key]
        public int CarritoId { get; set; }

        [ForeignKey("ProductoId")]
        public Producto producto { get; set; }
        public decimal precioCarrito { get; set; }
        public EstadoCarritoEnum estadoCarritoEnum { get; set; }
    }
}
