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
    public class MarcaRepository : IMarca<MarcaDTO>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public MarcaRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(MarcaDTO entity)
        {
            var model = await _context.Tbmarca.SingleOrDefaultAsync(x => x.IdMarca == entity.IdMarca);
            if (model == null)
                return false;
            _context.Tbmarca.Remove(model);
            int query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Exists(MarcaDTO entity)
        {
            return await _context.Tbmarca.AnyAsync(e => e.IdMarca == entity.IdMarca);
        }

        public async Task<IEnumerable<MarcaDTO>> Get()
        {
            return _mapper.Map<IEnumerable<MarcaDTO>>(await _context.Tbmarca.ToListAsync());
        }

        public async Task<MarcaDTO> GetById(MarcaDTO entity)
        {
            var model = await _context.Tbmarca.Where(x => x.IdMarca == entity.IdMarca).FirstOrDefaultAsync();
            return _mapper.Map<MarcaDTO>(model);
        }

        public async Task<bool> Post(MarcaDTO entity)
        {
            var model = _mapper.Map<Tbmarca>(entity);
            _context.Tbmarca.Add(model);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Put(MarcaDTO entity)
        {
            _context.Entry(_mapper.Map<Tbmarca>(entity)).State = EntityState.Modified;
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return true;
            else
                return false;
        }
    }
}
