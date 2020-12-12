using API.Domain.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class EgresoConceptoRepository : IEgresoConcepto<EgresoConceptoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public EgresoConceptoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(EgresoConceptoDTO entity)
        {
            var model = await _context.Tbegresoconcepto.SingleOrDefaultAsync(x => x.IdConcepto == entity.IdConcepto);
            if (model == null)
                return false;
            _context.Tbegresoconcepto.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(EgresoConceptoDTO entity)
        {
            return await _context.Tbegresoconcepto.AnyAsync(e => e.IdConcepto == entity.IdConcepto);
        }

        public async Task<IEnumerable<EgresoConceptoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<EgresoConceptoDTO>>(await _context.Tbegresoconcepto.ToListAsync());
        }

        public async Task<EgresoConceptoDTO> GetById(EgresoConceptoDTO entity)
        {
            var model = await _context.Tbegresoconcepto.Where(x => x.IdConcepto == entity.IdConcepto).FirstOrDefaultAsync();
            return _mapper.Map<EgresoConceptoDTO>(model);
        }

        public async Task<bool> Post(EgresoConceptoDTO entity)
        {
            var model = _mapper.Map<Tbegresoconcepto>(entity);
            _context.Tbegresoconcepto.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(EgresoConceptoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbegresoconcepto>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
