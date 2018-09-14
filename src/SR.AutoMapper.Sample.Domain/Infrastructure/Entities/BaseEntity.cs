using System;

namespace SR.AutoMapper.Sample.Domain.Infrastructure.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool Deleted { get; set; }
    }
}