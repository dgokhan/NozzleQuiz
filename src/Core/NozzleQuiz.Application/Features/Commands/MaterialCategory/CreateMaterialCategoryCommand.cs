using AutoMapper;
using MediatR;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Application.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace NozzleQuiz.Application.Features.Commands.MaterialCategory
{
    public class CreateMaterialCategoryCommand : IRequest<IResult<string>>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ParentMaterialCategoryId { get; set; }

        public class CreateMaterialCategoryHandler : IRequestHandler<CreateMaterialCategoryCommand, IResult<string>>
        {
            private readonly IMaterialCategoryRepository materialCategoryRepository;
            private readonly IMapper mapper;

            public CreateMaterialCategoryHandler(IMaterialCategoryRepository materialCategoryRepository, IMapper mapper)
            {
                this.materialCategoryRepository = materialCategoryRepository;
                this.mapper = mapper;
            }

            public async Task<IResult<string>> Handle(CreateMaterialCategoryCommand request, CancellationToken cancellationToken)
            {
                var categoryMaterial = mapper.Map<Domain.Entities.MaterialCategory>(request);
                await materialCategoryRepository.AddAsync(categoryMaterial);

                return Result.Func<string>(categoryMaterial.Id);
            }
        }
    }
}
