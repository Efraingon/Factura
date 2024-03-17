using Abp.Application.Services;
using AutoMapper;
using FacturaApp.Factura.DTO;
using FacturaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Factura {
    public class FacturaAppService:ApplicationService, IFacturaAppService {
        private readonly IFacturaManager _FacturaManager;
        private readonly IMapper _mapper;
        public FacturaAppService(IFacturaManager FacturaManager, IMapper mapper) {
            _FacturaManager = FacturaManager;
            _mapper = mapper;
        }

        public async Task Create(CreateFacturaInput input) {
            FacturaModel output = _mapper.Map<CreateFacturaInput,FacturaModel>(input);
            await _FacturaManager.Create(output);
        }

        public void Delete(DeleteFacturaInput input) {
             _FacturaManager.Delete(input.idFactura);
        }

        public GetFacturaOutput GetFacturaById(GetFacturaInput input) {
            var getFactura = _FacturaManager.GetFacturaByID(input.idFactura);
            GetFacturaOutput output = _mapper.Map<FacturaModel,GetFacturaOutput>(getFactura);
            return output;
        }

        public IEnumerable<GetFacturaOutput> ListAll() {
             var getAll = _FacturaManager.GetAlllist().ToList();
            List<GetFacturaOutput> output = _mapper.Map<List<FacturaModel>,List<GetFacturaOutput>>(getAll);
            return output;
        }

        public void Update(UpdateFacturaInput input) {
            FacturaModel output = _mapper.Map<UpdateFacturaInput,FacturaModel>(input);
        _FacturaManager.Update(output);
        }
    }
}
