using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoReporteService : ITipoReporteService<TipoReporteDTO>
    {
        private readonly ITipoReporte<TipoReporteDTO> _repository;

        public TipoReporteService(ITipoReporte<TipoReporteDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(TipoReporteDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(TipoReporteDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<TipoReporteDTO> GetById(TipoReporteDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<TipoReporteDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(TipoReporteDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(TipoReporteDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
