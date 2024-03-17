using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models
{
    public class Status : FullAuditedEntity
    {
        public Status()
        {

            Facturas = new HashSet<FacturaModel>();
        }
        [Key]
        public int IdStatus{ get; set; }

        [Required]
        [Display(Name = "Status")]
        [StringLength(50, ErrorMessage = "Maxima longitud es 50")]
        public string Descripcion { get; set; }
        public virtual ICollection<FacturaModel> Facturas { get; set; }

    }
}
