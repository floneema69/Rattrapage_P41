using Cars.DataContext;
using Cars.DataSource;
using Cars.DataSource.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cars.WebUI;

public static class ServicesExtensionMethods
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("EventTrackerDb");
        services.AddDbContext<MainDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IEntrepriseDataSource, EntrepriseDataSource>();
        services.AddScoped<IVehiculesDataSource, VehiculesDataSources>();
        services.AddScoped<ISalarierDataSource, SalarierDataSources>();

        return services;
    }
}