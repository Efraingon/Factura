
namespace FacturaApp.Models{
    using Abp.Domain.Repositories;
    using Abp.Domain.Services;
    using Abp.UI;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FacturaManager:DomainService, IFacturaManager {
        private readonly IRepository<FacturaModel> _repositoryFactura;

        public FacturaManager(IRepository<FacturaModel> repositoryFactura) {
            _repositoryFactura = repositoryFactura;
        }

        public async Task<FacturaModel> Create(FacturaModel entity) {
            var Factura = _repositoryFactura.FirstOrDefault(x => x.idFactura == entity.idFactura);
            if(Factura != null) {
                throw new UserFriendlyException("Ya existe");
                } else {
            return await _repositoryFactura.InsertAsync(entity);
            }
        }

        public void Delete(int id) {
            var Factura = _repositoryFactura.FirstOrDefault(x => x.idFactura == id);
            if(Factura == null) {
             throw new UserFriendlyException("No encontraron Data");
            } else {
                _repositoryFactura.Delete(Factura);

            }
        }

        public IEnumerable<FacturaModel> GetAlllist() {
        return _repositoryFactura.GetAllIncluding(x => x.idFactura);
        }

        public FacturaModel GetFacturaByID(int id) {
            return _repositoryFactura.Get(id);
        }

        public void Update(FacturaModel entidy) {
        _repositoryFactura.Update(entidy);
        }
    }
}
