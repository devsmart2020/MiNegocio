using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoProductoService : ITipoProductoService<Tbtipoproducto>
    {
        private readonly ITipoProducto<Tbtipoproducto> _repository;

        public TipoProductoService(ITipoProducto<Tbtipoproducto> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbtipoproducto entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbtipoproducto entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbtipoproducto> GetById(Tbtipoproducto entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbtipoproducto>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbtipoproducto> Post(Tbtipoproducto entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbtipoproducto> Put(Tbtipoproducto entity)
        {
            return await _repository.Put(entity);
        }
    }
}
