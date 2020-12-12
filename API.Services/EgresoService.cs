using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EgresoService : IEgresoService<EgresoDTO>
    {
        private readonly IEgreso<EgresoDTO> _repository;

        public EgresoService(IEgreso<EgresoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(EgresoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(EgresoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<EgresoDTO> GetById(EgresoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<EgresoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(EgresoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(EgresoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }

}
