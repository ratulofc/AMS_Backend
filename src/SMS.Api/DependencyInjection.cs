using SMS.Core.Interfaces.Repositories;
using SMS.Core.Interfaces.Services;
using SMS.Core.Services;
using SMS.Infrastructure.Repositories;

namespace SMS.Api
{
    internal static class DependencyInjection
    {
        internal static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();


            services.AddScoped<IParentService, ParentService>();
            return services;
        }
    }
}
