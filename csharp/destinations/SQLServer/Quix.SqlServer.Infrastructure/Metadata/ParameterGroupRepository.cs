using System.Data;
using Microsoft.Extensions.Logging;
using Quix.SqlServer.Domain.Models;
using Quix.SqlServer.Domain.Repositories;
using Quix.SqlServer.Infrastructure.Shared;

namespace Quix.SqlServer.Infrastructure.Metadata
{
    public class ParameterGroupRepository : SqlServerRepository<TelemetryParameterGroup>, IParameterGroupRepository
    {
        public ParameterGroupRepository(IDbConnection readerDatabaseConnection, IDbConnection writerDatabaseConnection, ILoggerFactory loggerFactory) : base(readerDatabaseConnection, writerDatabaseConnection, loggerFactory.CreateLogger<ParameterGroupRepository>())
        {
        }
    }
}