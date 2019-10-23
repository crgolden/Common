namespace Common
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using static Microsoft.Extensions.Logging.LogLevel;

    public interface IDataService
    {
        DataServiceType Type { get; }

        string? Name { get; set; }

        Task<T> CreateAsync<T>(
            T? record,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where T : class;

        Task<T?> ReadAsync<T>(
            Expression<Func<T, bool>>? expression,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where T : class;

        Task UpdateAsync<T>(
            Expression<Func<T, bool>>? expression,
            T? record,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where T : class;

        Task DeleteAsync<T>(
            Expression<Func<T, bool>>? expression,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where T : class;

        IQueryable<T> List<T>(LogLevel logLevel = Information)
            where T : class;
    }
}
