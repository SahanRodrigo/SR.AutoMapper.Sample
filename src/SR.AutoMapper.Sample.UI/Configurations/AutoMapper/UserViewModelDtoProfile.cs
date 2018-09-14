using System;
using AutoMapper;
using SR.AutoMapper.Sample.Services.Dtos;
using SR.AutoMapper.Sample.UI.Configurations.AutoMapper.Resolvers;
using SR.AutoMapper.Sample.UI.ViewModels;

namespace SR.AutoMapper.Sample.UI.Configurations.AutoMapper
{
    public class UserViewModelDtoProfile : Profile
    {
        public UserViewModelDtoProfile()
        {
            CreateMap<UserDto, UserViewModel>()
                .ForMember(dest => dest.FullName,
                    opts => opts.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Age,
                    opts => opts.ResolveUsing<AgeResolver>());

            CreateMap<UserViewModel, UserDto>();
        }
    }
}