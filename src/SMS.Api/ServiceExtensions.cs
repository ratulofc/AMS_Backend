using Microsoft.EntityFrameworkCore;
using SMS.Infrastructure.Context;

namespace SMS.Api
{
    internal static class ServiceExtensions
    {
        internal static void ConfigureDBContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<SMSDBContext>(opt =>
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConStr"))
            );
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddCors(options =>
                options.AddPolicy("corspolicy", build =>
                {
                    build.WithOrigins("http://localhost:5173")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                }));
        }
    }
}
