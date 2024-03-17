using Abp.Application.Services;
using FacturaApp.FacturaDocumento.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.FacturaDocumento {
    public interface IFacturaDocumentoAppService:IApplicationService {

        IEnumerable<GetFacturaDocumentoOutput> ListAll();
        Task Create(CreateFacturaDocumentoInput input);
        void Update(UpdateFacturaDocumentoInput input);
        void Delete(DeleteFacturaDocumentoInput input);
        GetFacturaDocumentoOutput GetFacturaDocumentoById(GetFacturaDocumentoInput input);

    }
}
