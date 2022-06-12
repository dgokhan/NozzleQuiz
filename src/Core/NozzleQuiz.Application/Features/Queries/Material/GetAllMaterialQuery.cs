using MediatR;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Application.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NozzleQuiz.Application.Features.Queries.Material
{
    public class GetAllMaterialQuery : IRequest<IResult<List<Domain.Entities.Material>>>
    {

        public class GetAllMaterialQueryHandler : IRequestHandler<GetAllMaterialQuery,IResult<List<Domain.Entities.Material>>>
        {
            private readonly IMaterialRepository materialRepository;

            public GetAllMaterialQueryHandler(IMaterialRepository materialRepository)
            {
                this.materialRepository = materialRepository;
            }
            public async Task<IResult<List<Domain.Entities.Material>>> Handle(GetAllMaterialQuery request, CancellationToken cancellationToken)
            {
                var material = await materialRepository.GetAllAsync();
                return Result.Func(material);
            }
        }
    }
}
