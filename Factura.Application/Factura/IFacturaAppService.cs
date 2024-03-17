using Abp.Application.Services;
using FacturaApp.Factura.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Factura {
    public interface IFacturaAppService:IApplicationService {
        IEnumerable<GetFacturaOutput> ListAll();
        Task Create(CreateFacturaInput input);
        void Update(UpdateFacturaInput input);
        void Delete(DeleteFacturaInput input);
        GetFacturaOutput GetFacturaById(GetFacturaInput input);
    }
}
