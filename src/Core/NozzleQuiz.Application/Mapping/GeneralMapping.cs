using AutoMapper;
using NozzleQuiz.Application.Dtos;
using NozzleQuiz.Application.Features.Commands.BaseUnitType;
using NozzleQuiz.Application.Features.Commands.MaterialCategory;

namespace NozzleQuiz.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.MaterialCategory, CreateMaterialCategoryCommand>()
                .ReverseMap();

            CreateMap<Domain.Entities.BaseUnitType, CreateBaseUnitTypeCommand>()
                .ReverseMap();
            
            CreateMap<Domain.Entities.MaterialCategory, MaterialCategoryDto>()
                .ReverseMap();
        }
    }
}
