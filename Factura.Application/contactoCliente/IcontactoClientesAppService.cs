using Abp.Application.Services;
using FacturaApp.contactoCliente.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.contactoCliente
{
    public interface IcontactoClientesAppService:IApplicationService
    {
        IEnumerable<GetcontactoClientesOutput> ListAll();
        Task Create(CreatecontactoClientesInput input);
        void Update(UpdatecontactoClientesInput input);
        void Delete(DeletecontactoClientesInput input);
        GetcontactoClientesOutput GetcontactoClientesById(GetcontactoClientesInput input);

   }
}
