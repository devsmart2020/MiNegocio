using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ITipoReporte : ITipoReporteService<Tbtiporeporte>
    {
        private readonly ITipoReporte<Tbtiporeporte> _repository;

        public ITipoReporte(ITipoReporte<Tbtiporeporte> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbtiporeporte entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbtiporeporte entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbtiporeporte> GetById(Tbtiporeporte entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbtiporeporte>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbtiporeporte> Post(Tbtiporeporte entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbtiporeporte> Put(Tbtiporeporte entity)
        {
            return await _repository.Put(entity);
        }
    }
}
