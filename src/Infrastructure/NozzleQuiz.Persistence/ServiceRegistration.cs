using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NozzleQuiz.Persistence.Context;

namespace NozzleQuiz.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistencecServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(@"Data Source=.;Initial Catalog=NozzleDb;Integrated Security=True"));

            //serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
