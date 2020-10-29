using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ProductoService : IProductoService<Tbproducto>
    {
        private readonly IProducto<Tbproducto> _repository;
        public ProductoService(IProducto<Tbproducto> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbproducto entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbproducto entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbproducto>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbproducto> GetById(Tbproducto entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbproducto> Post(Tbproducto entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbproducto> Put(Tbproducto entity)
        {
            return await _repository.Put(entity);
        }
    }
}
