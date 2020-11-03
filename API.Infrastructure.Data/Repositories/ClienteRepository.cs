using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Data.Repositories
{
    public class ClienteRepository : ICliente<Tbcliente>
    {
        private readonly soport43_minegocioContext _context;

        public ClienteRepository(soport43_minegocioContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(Tbcliente entity)
        {
            if (await Exists(entity))
            {
                _context.Tbcliente.Remove(entity);
                var query = await _context.SaveChangesAsync();
                if (query > 0)
                    return true;
                else
                    return false;

            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Exists(Tbcliente entity)
        {
            return await _context.Tbcliente.AnyAsync(e => e.DocId == entity.DocId);
        }

        public async Task<IEnumerable<Tbcliente>> Get()
        {
            return await _context.Tbcliente
                .OrderBy(x => x.Nombres)
                .ToListAsync();
        }

        public async Task<Tbcliente> GetById(Tbcliente entity)
        {
            return await _context.Tbcliente
                .Where(x => x.DocId == entity.DocId)
                .FirstOrDefaultAsync();
        }

        public async Task<Tbcliente> Post(Tbcliente entity)
        {
            await _context.Tbcliente.AddAsync(entity);
            var query = await _context.SaveChangesAsync();
            if (query > 0)
                return await GetById(entity);
            else
                return null;
        }

        public async Task<Tbcliente> Put(Tbcliente entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                var query = await _context.SaveChangesAsync();
                if (query > 0)
                    return await GetById(entity);
                else
                    return null;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await Exists(entity))
                    return null;
                else
                    throw;
            }
        }

        public async Task<IEnumerable<Tbcliente>> RptEquiposxCliente(Tbcliente entity)
        {
            return await _context.Tbcliente
               .Where(x => x.DocId.Equals(entity.DocId))
               .Select(x => new Tbcliente
               {
                   DocId = x.DocId,
                   Nombres = x.Nombres,
                   Apellidos = x.Apellidos,
                   Direccion = x.Direccion,
                   Telefono = x.Telefono,
                   TelAlternativo = x.TelAlternativo,
                   Email = x.Email,
                   Estado = x.Estado,
                   CodRecuperacion = x.CodRecuperacion,
                   Fecha = x.Fecha,
                   Tbequipo = x.Tbequipo.Where(e => e.IdCliente.Equals(x.DocId))
                   .Select(n => new Tbequipo
                   {
                       IdEquipo = n.IdEquipo,
                       Fecha = n.Fecha,
                       IdCliente = n.IdCliente,   
                       TipoEquipo = n.IdModeloNavigation.TipoEquipoNavigation.TipoEquipo,
                       Marca = n.IdModeloNavigation.MarcaNavigation.Marca,
                       IdModelo = n.IdModelo,
                       Modelo = n.IdModeloNavigation.Modelo,
                       Serie = n.Serie,
                       Imei1 = n.Imei1,
                       Imei2 = n.Imei2,
                       Color = n.Color,
                       Observacion = n.Observacion
                   })
                   .ToList()
               }).ToListAsync();
        }
    }
}
