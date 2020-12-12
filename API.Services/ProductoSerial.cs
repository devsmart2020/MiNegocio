using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ProductoSerial : IProductoSerialService<ProductoSerialDTO>
    {
        private readonly IProductoSerial<ProductoSerialDTO> _repository;

        public ProductoSerial(IProductoSerial<ProductoSerialDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(ProductoSerialDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ProductoSerialDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<ProductoSerialDTO> GetById(ProductoSerialDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<ProductoSerialDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(ProductoSerialDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ProductoSerialDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
