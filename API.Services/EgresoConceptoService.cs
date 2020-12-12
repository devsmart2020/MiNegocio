using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EgresoConceptoService : IEgresoConceptoService<EgresoConceptoDTO>
    {
        private readonly IEgresoConcepto<EgresoConceptoDTO> _repository;

        public EgresoConceptoService(IEgresoConcepto<EgresoConceptoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(EgresoConceptoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(EgresoConceptoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<EgresoConceptoDTO> GetById(EgresoConceptoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<EgresoConceptoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(EgresoConceptoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(EgresoConceptoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
