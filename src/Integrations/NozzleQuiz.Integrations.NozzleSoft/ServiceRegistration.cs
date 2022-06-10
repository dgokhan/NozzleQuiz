using Microsoft.Extensions.DependencyInjection;
using NozzleQuiz.Integrations.NozzleSoft.Api;
using NozzleQuiz.Integrations.NozzleSoft.Client;
using NozzleQuiz.Integrations.NozzleSoft.Client.InventoryManagement;

namespace NozzleQuiz.Integrations.NozzleSoft
{
    public static class ServiceRegistration
    {
        public static void AddIntegrationRegistration(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBaseApi, BaseApi>();
            serviceCollection.AddTransient<IMaterialCategoryApi, MaterialCategoryApi>();
            serviceCollection.AddTransient<IMaterialCategory, MaterialCategory>();
        }
    }
}
