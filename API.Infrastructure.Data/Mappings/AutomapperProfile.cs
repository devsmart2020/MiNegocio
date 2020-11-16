using API.Domain.DTOs;
using API.Domain.Entities;
using AutoMapper;

namespace API.Infrastructure.Data.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Tbcliente, ClienteDto>();
            CreateMap<ClienteDto, Tbcliente>();
        }
    }
}
