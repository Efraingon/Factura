
namespace FacturaApp.Models {
    using Abp.Domain.Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public interface IFacturaDocumentoManager:IDomainService {
        IEnumerable<FacturaDocumentoModel> GetAlllist();
        FacturaDocumentoModel GetFacturaDocumentoByID(int id);
        Task<FacturaDocumentoModel> Create(FacturaDocumentoModel entity);
        void Update(FacturaDocumentoModel entidy);
        void Delete(int id);
    }
}
