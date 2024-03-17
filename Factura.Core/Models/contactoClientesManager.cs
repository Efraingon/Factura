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
    public class contactoClientesManager : DomainService, IcontactoClientesManager
    {
        private readonly IRepository<contactoClientes> _repositoryContactoCliente;
        public contactoClientesManager(IRepository<contactoClientes> repositoryContactoCliente)
        {
            _repositoryContactoCliente = repositoryContactoCliente;
        }

        public async Task<contactoClientes> Create(contactoClientes entity)
        {
            var Contactocliente = _repositoryContactoCliente.FirstOrDefault(x => x.Id == entity.Id);
            if (Contactocliente != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return await _repositoryContactoCliente.InsertAsync(entity);
            }
           
        }

        public void Delete(int id)
        {
            var Contactocliente = _repositoryContactoCliente.FirstOrDefault(x => x.Id == id);
            if (Contactocliente == null)
            {
                throw new UserFriendlyException("No encontraron Data");
            }
            else
            {
                _repositoryContactoCliente.Delete(Contactocliente);

            }

        }

        public IEnumerable<contactoClientes> GetAlllist()
        {
            return _repositoryContactoCliente.GetAllIncluding(x => x.Cliente);
        }

        public contactoClientes GetIdContacto(int id)
        {
            return _repositoryContactoCliente.Get(id);
        }

        public void Update(contactoClientes entidy)
        {
            _repositoryContactoCliente.Update(entidy);
        }
    }
}
