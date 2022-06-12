using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Persistence.Context;
using NozzleQuiz.Persistence.Repository;

namespace NozzleQuiz.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistencecServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(@"Data Source=.;Initial Catalog=NozzleQuizDb;Integrated Security=True"));

            serviceCollection.AddTransient<IMaterialCategoryRepository, MaterialCategoryRepository>();
            serviceCollection.AddTransient<IMaterialRepository, MaterialRepository>(); 
            serviceCollection.AddTransient<IBaseUnitTypeRepository, BaseUnitTypeRepository>(); 
        }
    }
}
