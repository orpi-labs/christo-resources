using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orpi.Christo.Resources.Core;
using Orpi.Christo.Resources.Core.Interfaces;
using Orpi.Christo.Resources.Infrastructure.Database;
using Orpi.Christo.Resources.Infrastructure.Repositories;

namespace Orpi.Christo.Resources.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfra(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDatabase(configuration);
        serviceCollection.AddScoped<ISampleRepository, SampleRepository>();
        
        return serviceCollection;
    }
}