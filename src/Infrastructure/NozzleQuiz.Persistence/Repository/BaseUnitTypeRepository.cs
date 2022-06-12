using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Domain.Entities;
using NozzleQuiz.Persistence.Context;

namespace NozzleQuiz.Persistence.Repository
{
    public class BaseUnitTypeRepository : GenericRepository<BaseUnitType>, IBaseUnitTypeRepository
    {
        public BaseUnitTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
