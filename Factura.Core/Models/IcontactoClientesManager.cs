using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Models
{
    public interface IcontactoClientesManager:IDomainService
    {
        IEnumerable<contactoClientes> GetAlllist();
        contactoClientes GetIdContacto(int id);
        Task<contactoClientes> Create(contactoClientes entity);
        void Update(contactoClientes entidy);
        void Delete(int id);


    }
}
