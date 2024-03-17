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
    public class ClientesManager : DomainService, IClientesManager
    {
        private readonly IRepository<Clientes> _repositoryCliente;
        public ClientesManager(IRepository<Clientes> repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public async Task<Clientes> Create(Clientes entity)
        {
            var cliente = _repositoryCliente.FirstOrDefault(x => x.Id == entity.Id);
            if (cliente != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return  await _repositoryCliente.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var cliente = _repositoryCliente.FirstOrDefault(x => x.Id == id);
            if (cliente == null)
            {
                throw new UserFriendlyException("No encontraron Data");
            }
            else
            {
                _repositoryCliente.Delete(cliente);

            }
        }

        public IEnumerable<Clientes> GetAlllist()
        {
            return _repositoryCliente.GetAllIncluding(x => x.contactoClientes);
        }

        public Clientes GetClienteByID(int id)
        {
            return _repositoryCliente.Get(id);
        }

        public void Update(Clientes entidy)
        {
            _repositoryCliente.Update(entidy);
        }
    }
}
