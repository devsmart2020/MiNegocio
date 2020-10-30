using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EgresoConceptoService : IEgresoConceptoService<Tbegresoconcepto>
    {
        private readonly IEgresoConcepto<Tbegresoconcepto> _repository;

        public EgresoConceptoService(IEgresoConcepto<Tbegresoconcepto> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbegresoconcepto entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbegresoconcepto entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbegresoconcepto> GetById(Tbegresoconcepto entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbegresoconcepto>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbegresoconcepto> Post(Tbegresoconcepto entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbegresoconcepto> Put(Tbegresoconcepto entity)
        {
            return await _repository.Put(entity);
        }
    }
}
