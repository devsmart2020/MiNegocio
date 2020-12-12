using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ReportesService : IReportesService<ReporteDTO>
    {
        private readonly IReportes<ReporteDTO> _repository;

        public ReportesService(IReportes<ReporteDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(ReporteDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ReporteDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<ReporteDTO> GetById(ReporteDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<ReporteDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(ReporteDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ReporteDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
