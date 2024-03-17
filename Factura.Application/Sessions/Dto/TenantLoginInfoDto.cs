using Abp.Application.Services.Dto;

using FacturaApp.MultiTenancy;

namespace FacturaApp.Sessions.Dto
{
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}