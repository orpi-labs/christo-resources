using Microsoft.Extensions.DependencyInjection;
using Orpi.Christo.Resources.Core.Interfaces;
using Orpi.Christo.Resources.Core.Services;

namespace Orpi.Christo.Resources.Core;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCore(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ISampleService, SampleService>();
        
        return serviceCollection;
    }
}