using Microsoft.EntityFrameworkCore;
using Orpi.Christo.Resources.Core;
using Orpi.Christo.Resources.Core.Models;

namespace Orpi.Christo.Resources.Infrastructure.Database;

public class ChristoContext(DbContextOptions<ChristoContext> options): DbContext(options)
{
    public required DbSet<SampleModel> SampleModels { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.UseSnakeCaseNaming();
        BuildSampleModel(builder);
    }
    
    private static void BuildSampleModel(ModelBuilder builder)
    {
        builder.Entity<SampleModel>().HasKey(x => x.Id);
    }
}