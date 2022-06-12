using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Domain.Entities;
using NozzleQuiz.Persistence.Context;

namespace NozzleQuiz.Persistence.Repository
{
    public class MaterialRepository : GenericRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
