using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.contactoCliente.DTO
{
    public class CreatecontactoClientesInput
    {
        public string Nombre { get; set; }
        public DateTime CreationTime { get; set;}
        public string Telefono { get; set; }

        public string Email { get; set; }


        public string Contacto { get; set; }

    }
}
