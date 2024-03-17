using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models
{
    public interface IStatusManager :IDomainService
    {
        IEnumerable<Status> GetAlllist();
        Status GetIdStatus(int id);
        Task<Status> Create(Status entity);
        void Update(Status entidy);
        void Delete(int id);

    }
}
