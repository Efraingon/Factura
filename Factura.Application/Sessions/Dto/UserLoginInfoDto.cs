using Abp.Application.Services.Dto;
using FacturaApp.Authorization.Users;
using FacturaApp.Users;

namespace FacturaApp.Sessions.Dto
{
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
