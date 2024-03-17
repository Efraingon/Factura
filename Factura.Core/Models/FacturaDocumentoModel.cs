
namespace FacturaApp.Models {
    using Abp.Domain.Entities.Auditing;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    [Table("FacturaDocumento")]
    public class FacturaDocumentoModel:FullAuditedEntity {
        [Key]
        public int idDocumento{ get; set; }
        [ForeignKey("Factura")]
        public int FacturaId { get; set; }
        public virtual FacturaModel Factura { get; set; }

        [Display(Name = "Precio sin Iva")]
        public decimal PrecioSinIva { get; set; }


        [Display(Name = "Precio con Iva")]
        public decimal PrecioconIva { get; set; }



        public virtual ICollection<FacturaModel> FacturaColletion { get; set; }
        public virtual ICollection<ProductoModel> ProductoColletion { get; set; }


        public FacturaDocumentoModel() {
            this.FacturaColletion = new HashSet<FacturaModel>();
            this.ProductoColletion = new HashSet<ProductoModel>();
        }
    }
}
