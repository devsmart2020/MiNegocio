using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class CompraService : ICompraService<CompraDTO>
    {
        private readonly ICompra<CompraDTO> _repository;

        public CompraService(ICompra<CompraDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(CompraDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(CompraDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<CompraDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<CompraDTO> GetById(CompraDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(CompraDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(CompraDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
