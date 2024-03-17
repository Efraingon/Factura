
namespace FacturaApp.Models {
  
    using Abp.Domain.Entities.Auditing;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("Factura")]
    public class FacturaModel :FullAuditedEntity {

        [Key]
        public int idFactura { get; set; }
      
        [Display(Name = "Numero")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int Numero { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Campo Requerido")]
        [MaxLength(60)]
        public string Descripcion { get; set; }

        [Display(Name = "Monto de Factura")]
        public decimal Monto { get; set; }

        [Display(Name = "Fecha Emsión")]
        public DateTime FechaEmision { get; set; }


        [Display(Name = "Status")]
        [Required(ErrorMessage = "Campo Requerido")]
        [MaxLength(60)]
        public string Status { get; set; }

        public virtual ICollection<Clientes> Cliente { get; set; }
        public virtual ICollection<FacturaDocumentoModel> FacturaDocumento { get; set; }
      
    


        public FacturaModel() {
            this.Cliente = new HashSet<Clientes>();
            this.FacturaDocumento = new HashSet<FacturaDocumentoModel>();
         


        }
    }
}

    

