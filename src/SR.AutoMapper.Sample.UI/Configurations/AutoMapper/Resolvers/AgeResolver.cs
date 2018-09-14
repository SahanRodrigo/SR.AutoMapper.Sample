using System;
using AutoMapper;
using SR.AutoMapper.Sample.Services.Dtos;
using SR.AutoMapper.Sample.UI.ViewModels;

namespace SR.AutoMapper.Sample.UI.Configurations.AutoMapper.Resolvers
{
    public class AgeResolver : IValueResolver<UserDto, UserViewModel, int>
    {
        public int Resolve(UserDto source, UserViewModel destination, int destMember, ResolutionContext context)
        {
            var today = DateTime.Today;
            var age = today.Year - source.DateOfBirth.Year;

            // Go back to the year the person was born in case of a leap year
            if (source.DateOfBirth > today.AddYears(-age)) age--;

            return age;
        }
    }
}