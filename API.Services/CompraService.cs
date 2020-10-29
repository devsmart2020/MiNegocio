using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class CompraService : ICompraService<Tbcompra>
    {
        private readonly ICompra<Tbcompra> _repository;

        public CompraService(ICompra<Tbcompra> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbcompra entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbcompra entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbcompra>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbcompra> GetById(Tbcompra entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbcompra> Post(Tbcompra entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbcompra> Put(Tbcompra entity)
        {
            return await _repository.Put(entity);
        }
    }
}
