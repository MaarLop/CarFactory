using Modules.CarFactory.Core.Extensions;
using Modules.CarFactory.Infraestructure.Extensions;

namespace Modules.CarFactory.Exensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddSaleModule(this IServiceCollection services)
        {
            services.AddCoreModule();
            services.AddInfraestructure();

            return services;
        }
    }
}
