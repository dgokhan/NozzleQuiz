using MediatR;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Application.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NozzleQuiz.Application.Features.Queries.Material
{
    public class GetAllBaseUnitTypeQuery : IRequest<IResult<List<Domain.Entities.BaseUnitType>>>
    {

        public class GetBaseUnitTypeQueryHandler : IRequestHandler<GetAllBaseUnitTypeQuery, IResult<List<Domain.Entities.BaseUnitType>>>
        {
            private readonly IBaseUnitTypeRepository baseUnitTypeRepository;

            public GetBaseUnitTypeQueryHandler(IBaseUnitTypeRepository baseUnitTypeRepository)
            {
                this.baseUnitTypeRepository = baseUnitTypeRepository;
            }
            public async Task<IResult<List<Domain.Entities.BaseUnitType>>> Handle(GetAllBaseUnitTypeQuery request, CancellationToken cancellationToken)
            {
                var material = await baseUnitTypeRepository.GetAllAsync();
                return Result.Func(material);
            }
        }
    }
}
