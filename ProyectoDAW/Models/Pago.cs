using ProyectoDAW.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDAW.Models
{
    public class Pago
    {
        [Key]
        public int PagoId { get; set; }
        public MeteodoPagoEnum metodoPago { get; set; }
        public decimal MontoPago { get; set; }


    }
}
