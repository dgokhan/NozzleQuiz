using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Domain.Entities;
using NozzleQuiz.Persistence.Context;

namespace NozzleQuiz.Persistence.Repository
{
    public class MaterialCategoryRepository : GenericRepository<MaterialCategory>, IMaterialCategoryRepository
    {
        public MaterialCategoryRepository(ApplicationDbContext dbContext) : base (dbContext)
        {

        }
    }
}
