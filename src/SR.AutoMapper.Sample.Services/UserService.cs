using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SR.AutoMapper.Sample.Domain.Repositories;
using SR.AutoMapper.Sample.Services.Dtos;
using SR.AutoMapper.Sample.Services.Extensions;

namespace SR.AutoMapper.Sample.Services
{
    public interface IUserService
    {
        UserDto GetUserById(Guid id);
        List<UserDto> GetUsers();
    }

    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }
        public UserDto GetUserById(Guid id)
        {
            return this.userRepository.GetUseById(id).ToDto<UserDto>(mapper);
        }

        public List<UserDto> GetUsers()
        {
            return this.userRepository.GetUsers().Select(u => u.ToDto<UserDto>(mapper)).ToList();
        }
    }
}