using Abp.Application.Services;
using AutoMapper;
using FacturaApp.contactoCliente.DTO;
using FacturaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.contactoCliente
{
    public class contactoClientesAppService:ApplicationService, IcontactoClientesAppService
    {
        private readonly IcontactoClientesManager _ContactoClientesManager;
        private readonly IMapper _mapper;
        public contactoClientesAppService(IcontactoClientesManager ContactoClientesManager, IMapper mapper)
        {
            _ContactoClientesManager = ContactoClientesManager;
            _mapper = mapper;
        }

        public async Task Create(CreatecontactoClientesInput input)
        {
            contactoClientes output = _mapper.Map<CreatecontactoClientesInput, contactoClientes>(input);
            await _ContactoClientesManager.Create(output);
            

        }

        public void Delete(DeletecontactoClientesInput input)
        {
            _ContactoClientesManager.Delete(input.Id);
        }

        public GetcontactoClientesOutput GetcontactoClientesById(GetcontactoClientesInput input)
        {
            var getContactoCliente = _ContactoClientesManager.GetIdContacto(input.Id);
            GetcontactoClientesOutput output = _mapper.Map<contactoClientes, GetcontactoClientesOutput>(getContactoCliente);
            return output;
        }

        public IEnumerable<GetcontactoClientesOutput> ListAll()
        {
            var getAll = _ContactoClientesManager.GetAlllist().ToList();
            List<GetcontactoClientesOutput> output = _mapper.Map< List<contactoClientes>, List<GetcontactoClientesOutput> >(getAll);
            return output;


        }

        public void Update(UpdatecontactoClientesInput input)
        {
            contactoClientes output = _mapper.Map<UpdatecontactoClientesInput, contactoClientes>(input);
            _ContactoClientesManager.Update(output);

        }
    }
}
