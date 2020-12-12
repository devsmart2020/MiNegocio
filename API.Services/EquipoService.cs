using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EquipoService : IEquipoService<EquipoDTO>
    {
        private readonly IEquipo<EquipoDTO> _repository;

        public EquipoService(IEquipo<EquipoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(EquipoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(EquipoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<EquipoDTO> GetById(EquipoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<EquipoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(EquipoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(EquipoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
