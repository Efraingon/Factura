using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models
{
    public interface IClientesManager:IDomainService
    {
        IEnumerable<Clientes> GetAlllist();
        Clientes GetClienteByID(int id);
        Task<Clientes> Create(Clientes entity);
        void Update(Clientes entidy);
        void Delete(int id);


    }
}
