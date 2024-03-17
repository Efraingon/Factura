using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

using Abp.MultiTenancy;

namespace FacturaApp.MultiTenancy.Dto
{
    public class TenantDto : EntityDto
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        [RegularExpression(Tenant.TenancyNameRegex)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(Tenant.MaxNameLength)]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
