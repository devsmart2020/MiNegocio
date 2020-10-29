using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ProductoSerial : IProductoSerialService<Tbproductoserial>
    {
        private readonly IProductoSerial<Tbproductoserial> _repository;

        public ProductoSerial(IProductoSerial<Tbproductoserial> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbproductoserial entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbproductoserial entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbproductoserial> GetById(Tbproductoserial entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbproductoserial>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbproductoserial> Post(Tbproductoserial entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbproductoserial> Put(Tbproductoserial entity)
        {
            return await _repository.Put(entity);
        }
    }
}
