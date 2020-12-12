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
    public class CreditoRepository : ICredito<CreditoDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public CreditoRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Delete(CreditoDTO entity)
        {
            var model = await _context.Tbcredito.SingleOrDefaultAsync(x => x.IdCredito == entity.IdCredito);
            if (model == null)
                return false;
            _context.Tbcredito.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(CreditoDTO entity)
        {
            return await _context.Tbcredito.AnyAsync(e => e.IdCredito == entity.IdCredito);
        }

        public async Task<IEnumerable<CreditoDTO>> Get()
        {
            return _mapper.Map<IEnumerable<CreditoDTO>>(await _context.Tbcredito.ToListAsync());
        }

        public async Task<CreditoDTO> GetById(CreditoDTO entity)
        {
            var model = await _context.Tbcredito.Where(x => x.IdCredito == entity.IdCredito).FirstOrDefaultAsync();
            return _mapper.Map<CreditoDTO>(model);
        }

        public async Task<bool> Post(CreditoDTO entity)
        {
            var model = _mapper.Map<Tbcredito>(entity);
            _context.Tbcredito.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(CreditoDTO entity)
        {
            _context.Entry(_mapper.Map<Tbcredito>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
