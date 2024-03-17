using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models {
    public class FacturaDocumentoManager:DomainService, IFacturaDocumentoManager {
        private readonly IRepository<FacturaDocumentoModel> _repositoryFacturaDocumento;
        public FacturaDocumentoManager(IRepository<FacturaDocumentoModel> repositoryFacturaDocumento) {
        _repositoryFacturaDocumento = repositoryFacturaDocumento;
        }

        public async Task<FacturaDocumentoModel> Create(FacturaDocumentoModel entity) {
            var FacturaDocumento = _repositoryFacturaDocumento.FirstOrDefault(x => x.idDocumento== entity.idDocumento);
            if(FacturaDocumento != null) {
            throw new UserFriendlyException("Ya existe");
            } else {
                return await _repositoryFacturaDocumento.InsertAsync(entity);
        }
        }

        public void Delete(int id) {
        var FacturaDocumento = _repositoryFacturaDocumento.FirstOrDefault(x => x.idDocumento == id);
        if(FacturaDocumento == null) {
        throw new UserFriendlyException("No encontraron Data");
        } else {
        _repositoryFacturaDocumento.Delete(FacturaDocumento);

        }
        }

        public IEnumerable<FacturaDocumentoModel> GetAlllist() {
            return _repositoryFacturaDocumento.GetAllIncluding(x => x.idDocumento);
        }

        public FacturaDocumentoModel GetFacturaDocumentoByID(int id) {
            return _repositoryFacturaDocumento.Get(id);
        }

        public void Update(FacturaDocumentoModel entidy) {
        _repositoryFacturaDocumento.Update(entidy);
        }
    }
}
