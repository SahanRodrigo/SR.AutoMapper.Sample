using AutoMapper;
using SR.AutoMapper.Sample.Domain.Infrastructure.Entities;
using SR.AutoMapper.Sample.Services.Dtos;

namespace SR.AutoMapper.Sample.Services.Configurations.AutoMapper
{
    public class UserDomainDtoProfile : Profile
    {
        public UserDomainDtoProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}