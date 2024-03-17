using Abp.Application.Services;

using FacturaApp.Cliente.DTO;
using FacturaApp.Models;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Cliente
{
    public class ClientesAppService : ApplicationService, IClientesAppService
    {
        private readonly IClientesManager _ClientesManager;
        private readonly IMapper _mapper;
        public ClientesAppService(IClientesManager ClientesManager, IMapper mapper)
        {
            _ClientesManager = ClientesManager;
            _mapper = mapper;
        }

        public async Task Create(CreateClientesInput input)
        {
            Clientes output = _mapper.Map<CreateClientesInput, Clientes>(input);
            await _ClientesManager.Create(output);
        }

        public void Delete(DeleteClientesInput input)
        {
            _ClientesManager.Delete(input.IdCliente);
        }

        public GetClientesOutput GetcontactoClientesById(GetClientesInput input)
        {
            var getCliente = _ClientesManager.GetClienteByID(input.IdCliente);
            GetClientesOutput output = _mapper.Map<Clientes, GetClientesOutput>(getCliente);
            return output;
        }

        public IEnumerable<GetClientesOutput> ListAll()
        {
            var getAll = _ClientesManager.GetAlllist().ToList();
            List<GetClientesOutput> output = _mapper.Map<List<Clientes>, List<GetClientesOutput>>(getAll);
            return output;

        }

        public void Update(UpdateClientesInput input)
        {
            Clientes output = _mapper.Map<UpdateClientesInput, Clientes>(input);
            _ClientesManager.Update(output);
        }
    }
}
