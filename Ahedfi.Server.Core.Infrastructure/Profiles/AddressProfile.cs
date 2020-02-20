using Ahedfi.Server.Core.Domain.Dtos;
using Ahedfi.Server.Core.Domain.Entities;
using AutoMapper;

namespace Ahedfi.Server.Core.Infrastructure.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
