using AutoMapper;
using MediatR;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Application.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NozzleQuiz.Application.Features.Queries.MaterialCategory
{
    public class GetAllMaterialCategoryQuery : IRequest<IResult<List<Domain.Entities.MaterialCategory>>>
    {
        public class GetAllMaterialCategoryQueryHandler : IRequestHandler<GetAllMaterialCategoryQuery, IResult<List<Domain.Entities.MaterialCategory>>>
        {
            private readonly IMaterialCategoryRepository materialCategoryRepository;
            public GetAllMaterialCategoryQueryHandler(IMaterialCategoryRepository materialCategoryRepository)
            {
                this.materialCategoryRepository = materialCategoryRepository;
            }
            public async Task<IResult<List<Domain.Entities.MaterialCategory>>> Handle(GetAllMaterialCategoryQuery request, CancellationToken cancellationToken)
            {
                var materialCategory = await materialCategoryRepository.GetAllAsync();
                return Result.Func(materialCategory);
            }
        }
    }
}
