﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Cliente.DTO
{
    public class CreateClientesInput
    {
       

        public string Nombre { get; set; }
        public DateTime CreationTime { get; set; }

        public string RFC { get; set; }

        public string NIT { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public int IdContacto { get; set; }
    }
}
