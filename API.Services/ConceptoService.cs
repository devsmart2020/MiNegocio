using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ConceptoService : IConceptoService<Tbconcepto>
    {
        private readonly IConcepto<Tbconcepto> _repository;

        public ConceptoService(IConcepto<Tbconcepto> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbconcepto entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbconcepto entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbconcepto>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbconcepto> GetById(Tbconcepto entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbconcepto> Post(Tbconcepto entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbconcepto> Put(Tbconcepto entity)
        {
            return await _repository.Put(entity);
        }
    }
}
