namespace FacturaApp.Models {
    using Abp.Domain.Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public interface IFacturaManager:IDomainService {

        IEnumerable<FacturaModel> GetAlllist();
        FacturaModel GetFacturaByID(int id);
        Task<FacturaModel> Create(FacturaModel entity);
        void Update(FacturaModel entidy);
        void Delete(int id);
    }
}
