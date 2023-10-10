using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.DB
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence
           (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<CinemaDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<ICinemaDbContext>(provider =>
            provider.GetService<CinemaDbContext>());

            return services;
        }
    }
}
