
namespace FacturaApp.Models
{
    using Abp.Domain.Entities.Auditing;
   
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Clientes : FullAuditedEntity
    {
       
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [Display(Name = "Nombre cliente")]
        [StringLength(50, ErrorMessage = "Maxima longitud es {0}")]
        public string Nombre { get; set; }

        [Display(Name = "RFC")]
        [StringLength(15, ErrorMessage = "Maxima longitud es {0}")]
        public string RFC { get; set; }

        [Display(Name = "NIT")]
        [StringLength(15, ErrorMessage = "Maxima longitud es {0}")]
        public string NIT { get; set; }

        [Display(Name = "Direccion")]
        [StringLength(100, ErrorMessage = "Maxima longitud es {0}")]
        public string Direccion { get; set; }


        [Display(Name = "Telefono")]
        [StringLength(15, ErrorMessage = "Maxima longitud es 80")]
        public string Telefono { get; set; }

        [ForeignKey("contactoClientes")]
        public int IdContacto { get; set; }
        public virtual contactoClientes contactoClientes { get; set; }

    }
}
