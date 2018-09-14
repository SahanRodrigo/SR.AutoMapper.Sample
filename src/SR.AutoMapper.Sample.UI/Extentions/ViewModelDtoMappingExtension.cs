using AutoMapper;
using SR.AutoMapper.Sample.Core.Exceptions;
using SR.AutoMapper.Sample.Services.Dtos;
using SR.AutoMapper.Sample.UI.ViewModels;

namespace SR.AutoMapper.Sample.UI.Extentions
{
    public static class ViewModelDtoMappingExtension
    {
        public static TViewModel ToViewModel<TViewModel>(this IDto dto, IMapper mapper) where TViewModel : IViewModel
        {
            var viewModel = mapper.Map<TViewModel>(dto);

            if (viewModel == null)
            {
                throw new ViewModelDtoMappingException($"Missing map from {dto.GetType()} to {typeof(TViewModel)}");
            }

            return viewModel;
        }

        public static TDto ToDto<TDto>(this IViewModel viewModel, IMapper mapper) where TDto : IDto
        {
            var dto = mapper.Map<TDto>(viewModel);

            if (viewModel == null)
            {
                throw new ViewModelDtoMappingException($"Missing map from {dto.GetType()} to {typeof(TDto)}");
            }

            return dto;
        }

    }
}