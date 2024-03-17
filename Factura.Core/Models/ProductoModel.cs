
namespace FacturaApp.Models
{
    using Abp.Domain.Entities.Auditing;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Producto")]

    public class ProductoModel : FullAuditedEntity
    {
        [Key]
        public int idProducto { get; set; }
      
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Campo Requerido")]
        [MaxLength(15)]
        public string Codigo { get; set; }


        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Campo Requerido")]
        [MaxLength(120)]
        public string Descripcion { get; set; }


        [Display(Name = "Precio sin Iva")]
        public decimal PrecioSinIva { get; set; }


        [Display(Name = "Precio con Iva")]
        public decimal PrecioconIva { get; set; }

        [Display(Name = "Existencia")]
        public decimal Existencia { get; set; }

    }
}
