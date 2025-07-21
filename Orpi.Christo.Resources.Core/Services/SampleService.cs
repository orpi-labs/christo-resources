using Orpi.Christo.Resources.Core.Interfaces;

namespace Orpi.Christo.Resources.Core.Services;

public class SampleService: ISampleService
{
    private readonly ISampleRepository _repository;

    public SampleService(ISampleRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> GetSampleDataAsync()
    {
       var result = await _repository.GetSampleDataAsync();

       return result ?? "hell nah";
    }
}