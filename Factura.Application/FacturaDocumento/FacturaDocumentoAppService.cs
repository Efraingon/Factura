using Abp.Application.Services;
using AutoMapper;
using FacturaApp.FacturaDocumento.DTO;
using FacturaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.FacturaDocumento {
    
    public class FacturaDocumentoAppService:ApplicationService, IFacturaDocumentoAppService {
        private readonly IFacturaDocumentoManager _FacturaDocumentoManager;
        private readonly IMapper _mapper;



        public FacturaDocumentoAppService(IFacturaDocumentoManager FacturaDocumentoManager, IMapper mapper) {
            _FacturaDocumentoManager = FacturaDocumentoManager;
            _mapper = mapper;
        }

        public async Task Create(CreateFacturaDocumentoInput input) {
            FacturaDocumentoModel output = _mapper.Map<CreateFacturaDocumentoInput,FacturaDocumentoModel>(input);
            await _FacturaDocumentoManager.Create(output);
        }

        public void Delete(DeleteFacturaDocumentoInput input) {
            _FacturaDocumentoManager.Delete(input.id);
        }

        public GetFacturaDocumentoOutput GetFacturaDocumentoById(GetFacturaDocumentoInput input) {
                var getFacturaDocumento = _FacturaDocumentoManager.GetFacturaDocumentoByID(input.id);
                GetFacturaDocumentoOutput output = _mapper.Map<FacturaDocumentoModel,GetFacturaDocumentoOutput>(getFacturaDocumento);
                return output;
        }

        public IEnumerable<GetFacturaDocumentoOutput> ListAll() {
            var getAll = _FacturaDocumentoManager.GetAlllist().ToList();
            List<GetFacturaDocumentoOutput> output = _mapper.Map<List<FacturaDocumentoModel>,List<GetFacturaDocumentoOutput>>(getAll);
            return output;
        }

        public void Update(UpdateFacturaDocumentoInput input) {
            FacturaDocumentoModel output = _mapper.Map<UpdateFacturaDocumentoInput,FacturaDocumentoModel>(input);
             _FacturaDocumentoManager.Update(output);
        }
    }
}
