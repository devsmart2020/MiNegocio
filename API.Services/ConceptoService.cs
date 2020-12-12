using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ConceptoService : IConceptoService<ConceptoDTO>
    {
        private readonly IConcepto<ConceptoDTO> _repository;

        public ConceptoService(IConcepto<ConceptoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(ConceptoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ConceptoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<ConceptoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<ConceptoDTO> GetById(ConceptoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(ConceptoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ConceptoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
