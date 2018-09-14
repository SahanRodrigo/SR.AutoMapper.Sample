using AutoMapper;
using SR.AutoMapper.Sample.Core.Exceptions;
using SR.AutoMapper.Sample.Domain.Infrastructure.Entities;
using SR.AutoMapper.Sample.Services.Dtos;

namespace SR.AutoMapper.Sample.Services.Extensions
{
    public static class DomainEntityDtoMappingExtension
    {
        public static TDto ToDto<TDto>(this IEntity entity, IMapper mapper) where TDto: IDto
        {
            var dto = mapper.Map<TDto>(entity);

            if (dto == null)
            {
                throw new DomainDtoMappingException($"Missing map from {entity.GetType()} to {typeof(TDto)}");
            }

            return dto;
        }

        public static TEntity ToEntity<TEntity>(this IDto dto, IMapper mapper) where TEntity : IEntity
        {
            var entity = mapper.Map<TEntity>(dto);

            if (entity == null)
            {
                throw new DomainDtoMappingException($"Missing map from {dto.GetType()} to {typeof(TEntity)}");
            }

            return entity;
        }
    }
}