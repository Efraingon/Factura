using Abp.Application.Services;
using FacturaApp.status.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.status
{
    public interface IstatusAppService : IApplicationService
    {
        IEnumerable<GetcontactostatusOutput> ListAll();
        Task Create(CreatecontactostatusInput input);
        void Update(UpdatecontactostatusInput input);
        void Delete(DeletecontactostatusInput input);
        GetcontactostatusOutput GetcontactoClientesById(GetcontactostatusInput input);

    }
}
