using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaProductoService : IVentaProductoService<VentaProductoDTO>
    {
        private readonly IVentaProducto<VentaProductoDTO> _repository;

        public VentaProductoService(IVentaProducto<VentaProductoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(VentaProductoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(VentaProductoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<VentaProductoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<VentaProductoDTO> GetById(VentaProductoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(VentaProductoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(VentaProductoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
