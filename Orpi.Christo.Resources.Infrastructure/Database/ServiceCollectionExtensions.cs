using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Orpi.Christo.Resources.Infrastructure.Database;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var datasourceBuilder = new NpgsqlDataSourceBuilder(configuration.GetConnectionString("DefaultConnection"));
        var datasource = datasourceBuilder.Build();
        services.AddDbContextPool<ChristoContext>(builder =>
        {
            builder.UseNpgsql(datasource);
        });
        
        return services;
    }
}