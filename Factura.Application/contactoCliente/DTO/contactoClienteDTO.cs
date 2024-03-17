using Abp.Application.Services.Dto;
//using Abp.AutoMapper;
using FacturaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.contactoCliente.DTO
{
   

    //[AutoMapTo(typeof(contactoClientes)), AutoMapFrom(typeof(contactoClientes))]
    public class contactoClienteDTO : EntityDto
    {
        //[Required]
        //[StringLength(AbpTenantBase.MaxTenancyNameLength)]
        //[RegularExpression(Tenant.TenancyNameRegex)]
        //public string TenancyName { get; set; }

        //[Required]
        //[StringLength(Tenant.MaxNameLength)]

        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
