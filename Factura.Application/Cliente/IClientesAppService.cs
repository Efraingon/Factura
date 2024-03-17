using Abp.Application.Services;
using FacturaApp.Cliente.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Cliente
{
    public interface IClientesAppService : IApplicationService
    {

        IEnumerable<GetClientesOutput> ListAll();
        Task Create(CreateClientesInput input);
        void Update(UpdateClientesInput input);
        void Delete(DeleteClientesInput input);
        GetClientesOutput GetcontactoClientesById(GetClientesInput input);
    }
}
