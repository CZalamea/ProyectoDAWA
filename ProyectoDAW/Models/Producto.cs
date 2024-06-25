using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace ProyectoDAW.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria categoria { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public decimal ProductoPrecio { get; set; }
        public bool ProductoEstado { get; set; }


    }
}
