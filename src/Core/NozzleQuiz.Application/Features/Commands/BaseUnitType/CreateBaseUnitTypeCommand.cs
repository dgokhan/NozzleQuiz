using AutoMapper;
using MediatR;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Application.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace NozzleQuiz.Application.Features.Commands.BaseUnitType
{
    public class CreateBaseUnitTypeCommand : IRequest<IResult<string>>
    {
        public string BaseUnitTypeID { get; set; }
        public string BaseUnitTypeDisplay { get; set; }
        public class BaseUnitTypeHandler : IRequestHandler<CreateBaseUnitTypeCommand, IResult<string>>
        {
            private readonly IBaseUnitTypeRepository baseUnitTypeRepository;
            private readonly IMapper mapper;

            public BaseUnitTypeHandler(IBaseUnitTypeRepository baseUnitTypeRepository, IMapper mapper)
            {
                this.baseUnitTypeRepository = baseUnitTypeRepository;
                this.mapper = mapper;
            }
            public async Task<IResult<string>> Handle(CreateBaseUnitTypeCommand request, CancellationToken cancellationToken)
            {
                var baseUnityType = mapper.Map<Domain.Entities.BaseUnitType>(request);
                await baseUnitTypeRepository.AddAsync(baseUnityType);

                return Result.Func<string>(baseUnityType.BaseUnitTypeID);
            }
        }
    }
}
