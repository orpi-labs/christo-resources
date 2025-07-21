namespace Orpi.Christo.Resources.Core.Interfaces;

public interface ISampleRepository
{
    Task<string?> GetSampleDataAsync();
}