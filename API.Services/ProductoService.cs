using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ProductoService : IProductoService<ProductoDTO>
    {
        private readonly IProducto<ProductoDTO> _repository;
        public ProductoService(IProducto<ProductoDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(ProductoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ProductoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<ProductoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<ProductoDTO> GetById(ProductoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(ProductoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ProductoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
