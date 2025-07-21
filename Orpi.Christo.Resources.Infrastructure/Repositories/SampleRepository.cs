using Microsoft.EntityFrameworkCore;
using Orpi.Christo.Resources.Core;
using Orpi.Christo.Resources.Core.Interfaces;
using Orpi.Christo.Resources.Infrastructure.Database;

namespace Orpi.Christo.Resources.Infrastructure.Repositories;

public class SampleRepository: ISampleRepository
{
    private readonly ChristoContext _context;

    public SampleRepository(ChristoContext context)
    {
        _context = context;
    }

    public async Task<string?> GetSampleDataAsync()
    {
        var result = await _context.SampleModels.FirstOrDefaultAsync();
        return result?.Id;
    }
}