using System;

namespace SR.AutoMapper.Sample.Core.Exceptions
{
    public class DomainDtoMappingException : Exception
    {
        public DomainDtoMappingException(string message) : base(message)
        {
        }
    }
}