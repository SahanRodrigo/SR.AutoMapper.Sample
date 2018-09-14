using System;

namespace SR.AutoMapper.Sample.Core.Exceptions
{
    public class ViewModelDtoMappingException : Exception
    {
        public ViewModelDtoMappingException(string message) : base(message)
        {
        }
    }
}