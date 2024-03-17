using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Factura.DTO {
    public class GetFacturaOutput {
        public int idFactura { get; set; }
        public int TenantId { get; set; }

        public int Numero { get; set; }
        public string Descripcion { get; set; }

        public string Status { get; set; }
    }
}
