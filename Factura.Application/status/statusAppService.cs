using Abp.Application.Services;
using AutoMapper;
using FacturaApp.Models;
using FacturaApp.status.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.status
{
    public class statusAppService : ApplicationService, IstatusAppService
    {
        private readonly IStatusManager _ContactoStatusManager;
        private readonly IMapper _mapper;

        public statusAppService(IStatusManager ContactoStatusManager,IMapper mapper)
        {
            _ContactoStatusManager = ContactoStatusManager;
            _mapper = mapper;
        }

        public async Task Create(CreatecontactostatusInput input)
        {
            Status output = _mapper.Map<CreatecontactostatusInput, Status>(input);
            await _ContactoStatusManager.Create(output);
        }

        public void Delete(DeletecontactostatusInput input)
        {
            _ContactoStatusManager.Delete(input.Id);
        }

        public GetcontactostatusOutput GetcontactoClientesById(GetcontactostatusInput input)
        {
            var getStatus = _ContactoStatusManager.GetIdStatus(input.Id);
            GetcontactostatusOutput output = _mapper.Map<Status, GetcontactostatusOutput>(getStatus);
            return output;
        }

        public IEnumerable<GetcontactostatusOutput> ListAll()
        {
            var getAll = _ContactoStatusManager.GetAlllist().ToList();
            List<GetcontactostatusOutput> output = _mapper.Map<List<Status>, List<GetcontactostatusOutput>>(getAll);
            return output;
        }

        public void Update(UpdatecontactostatusInput input)
        {
            Status output = _mapper.Map<UpdatecontactostatusInput, Status>(input);
            _ContactoStatusManager.Update(output);
        }
    }
}
