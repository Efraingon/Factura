using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models
{
    public class StatusManager : DomainService, IStatusManager
    {
        private readonly IRepository<Status> _repositoryStatus;
        public StatusManager(IRepository<Status> repositoryStatus)
        {
            _repositoryStatus = repositoryStatus;
        }

        public async Task<Status> Create(Status entity)
        {
            var status = _repositoryStatus.FirstOrDefault(x => x.IdStatus == entity.IdStatus);
            if (status != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return await _repositoryStatus.InsertAsync(entity);
            }

        }

        public void Delete(int id)
        {
            var status = _repositoryStatus.FirstOrDefault(x => x.IdStatus == id);
            if (status == null)
            {
                throw new UserFriendlyException("No encontraron Data");
            }
            else
            {
                _repositoryStatus.Delete(status);

            }
        }

        public IEnumerable<Status> GetAlllist()
        {
            return _repositoryStatus.GetAll();
        }

        public Status GetIdStatus(int id)
        {
            return _repositoryStatus.Get(id);
        }

        public void Update(Status entidy)
        {
            _repositoryStatus.Update(entidy);
        }
    }
}
