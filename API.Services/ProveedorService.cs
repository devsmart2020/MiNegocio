using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ProveedorService : IProveedorService<ProveedorDTO>
    {
        private readonly IProveedor<ProveedorDTO> _repository;

        public ProveedorService(IProveedor<ProveedorDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(ProveedorDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ProveedorDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<ProveedorDTO> GetById(ProveedorDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<ProveedorDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(ProveedorDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ProveedorDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
