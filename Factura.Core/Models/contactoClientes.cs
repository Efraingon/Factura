using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models
{
    public class contactoClientes : FullAuditedEntity
    {
        public contactoClientes()
        {
           // HashSet<Clientes> Cliente;

            Cliente = new HashSet<Clientes>();
        }



        [Key]
        public int IdContacto { get; set; }

        [Required]
        [Display(Name="Contacto")]
        [StringLength(50,ErrorMessage = "Maxima longitud es {0}")]
        public string Nombre { get; set; }

        [Display(Name = "Télefono")]
        [StringLength(15, ErrorMessage = "Maxima longitud es {0}")]
        public string Telefono { get; set; }

        [Display(Name = "Email")]
        [StringLength(80, ErrorMessage = "Maxima longitud es 80")]
        public string Email { get; set; }

        [Display(Name = "Contacto")]
        [StringLength(15, ErrorMessage = "Maxima longitud es {0}")]

        public string Contacto { get; set; }

        public virtual ICollection<Clientes> Cliente { get; set; }

    }
}
