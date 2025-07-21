using Grpc.Core;
using Orpi.Christo.Resources.CommonApi;
using Orpi.Christo.Resources.Core.Interfaces;

namespace Orpi.Christo.Resources.Api.Services;

public class CommonApiGrpcService: CommonApi.CommonApi.CommonApiBase
{
    private readonly ISampleService _sampleService;

    public CommonApiGrpcService(ISampleService sampleService)
    {
        _sampleService = sampleService;
    }

    public override async Task<GetSampleDataReply> GetSampleData(GetSampleDataRequest request, ServerCallContext context)
    {
        var result = await _sampleService.GetSampleDataAsync();

        return new GetSampleDataReply()
        {
            Data = result
        };
    }
}