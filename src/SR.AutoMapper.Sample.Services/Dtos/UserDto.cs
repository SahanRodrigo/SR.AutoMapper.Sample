using System;
using SR.AutoMapper.Sample.Domain.Infrastructure.Entities;

namespace SR.AutoMapper.Sample.Services.Dtos
{
    public class UserDto : IDto
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool Deleted { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}