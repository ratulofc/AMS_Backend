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


            return services;
        }
    }
}
