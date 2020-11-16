﻿using API.Domain.DTOs;
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
    public class ClienteRepository : ICliente<Tbcliente>
    {
        private readonly soport43_minegocioContext _context;
        private readonly IMapper _mapper;

        public ClienteRepository(soport43_minegocioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
              IEnumerable<Tbcliente> query =  await _context.Tbcliente
                .OrderBy(x => x.Nombres)
                .ToListAsync();
            return  _mapper.Map<ClienteDto>(query);
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

        public async Task<IEnumerable<Tbcliente>> RptOrdenxCliente(Tbcliente entity)
        {
            return await _context.Tbcliente
            .Where(x => x.DocId.Equals(entity.DocId))
            .Select(x => new Tbcliente
            {
                DocId = x.DocId,
                Nombres = x.Nombres,
                Apellidos = x.Apellidos,
                Telefono = x.Telefono,
                Tborden = x.Tborden.Where(o => o.IdCliente.Equals(x.DocId))
                .Select(n => new Tborden
                {
                    IdOrden = n.IdOrden,
                    //TipoEquipo = n.IdEquipoNavigation.IdModeloNavigation.TipoEquipoNavigation.TipoEquipo,
                    //Marca = n.IdEquipoNavigation.IdModeloNavigation.MarcaNavigation.Marca,
                    //Equipo = n.IdEquipoNavigation.IdModeloNavigation.Modelo,
                    IdCliente = n.IdCliente,
                    FechaEntra = n.FechaEntra,
                    FechaSale = n.FechaSale,
                    MicroSd = n.MicroSd,
                    Sim = n.Sim,
                    DatosBloqueo = n.DatosBloqueo,
                    DiagnosticoCliente = n.DiagnosticoCliente,
                    DiagnosticoTecnico = n.DiagnosticoTecnico,
                    Ubicacion = n.Ubicacion,
                    IdUsuario = n.IdUsuario,
                    IdEstadoOrden = n.IdEstadoOrden
                }).ToList()
            }).ToListAsync();
        }
    }
}
