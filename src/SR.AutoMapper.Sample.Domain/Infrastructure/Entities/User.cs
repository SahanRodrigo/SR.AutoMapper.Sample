using System;

namespace SR.AutoMapper.Sample.Domain.Infrastructure.Entities
{
    public class User : BaseEntity, IEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}