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
    public class TarifaRepository : ITarifa<TarifaDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;
        public TarifaRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(TarifaDTO entity)
        {
            var model = await _context.Tbtarifa.SingleOrDefaultAsync(x => x.IdTarifa == entity.IdTarifa);
            if (model == null)
                return false;
            _context.Tbtarifa.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(TarifaDTO entity)
        {
            return await _context.Tbtarifa.AnyAsync(e => e.IdTarifa == entity.IdTarifa);
        }

        public async Task<IEnumerable<TarifaDTO>> Get()
        {
            return _mapper.Map<IEnumerable<TarifaDTO>>(await _context.Tbtarifa.ToListAsync());
        }

        public async Task<TarifaDTO> GetById(TarifaDTO entity)
        {
            var model = await _context.Tbtarifa.Where(x => x.IdTarifa == entity.IdTarifa).FirstOrDefaultAsync();
            return _mapper.Map<TarifaDTO>(model);
        }

        public async Task<bool> Post(TarifaDTO entity)
        {
            var model = _mapper.Map<Tbtarifa>(entity);
            _context.Tbtarifa.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(TarifaDTO entity)
        {
            _context.Entry(_mapper.Map<Tbtarifa>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
