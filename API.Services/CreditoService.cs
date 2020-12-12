using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class CreditoService : ICreditoService<CreditoDTO>
    {
        private readonly ICredito<CreditoDTO> _repository;

        public CreditoService(ICredito<CreditoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(CreditoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(CreditoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<CreditoDTO> GetById(CreditoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<CreditoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(CreditoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(CreditoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
