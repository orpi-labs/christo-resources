using Microsoft.EntityFrameworkCore;
using Orpi.Christo.Resources.Core;
using Orpi.Christo.Resources.Core._Common;

namespace Orpi.Christo.Resources.Infrastructure.Database;

internal static class ModelBuilderExtensions
{
    internal static void UseSnakeCaseNaming(this ModelBuilder builder)
    {
        foreach (var entity in builder.Model.GetEntityTypes())
        {
            // Replace table names
            entity.SetTableName(entity.GetTableName().ToSnakeCase());

            // Replace column names
            foreach (var property in entity.GetProperties())
                property.SetColumnName(property.Name.ToSnakeCase());

            foreach (var key in entity.GetKeys())
                key.SetName(key.GetName().ToSnakeCase());

            foreach (var key in entity.GetForeignKeys())
                key.SetConstraintName(key.GetConstraintName().ToSnakeCase());

            foreach (var index in entity.GetIndexes())
                index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
        }
    }
}
