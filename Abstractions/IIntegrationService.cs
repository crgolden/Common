namespace Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using static Microsoft.Extensions.Logging.LogLevel;

    public interface IIntegrationService
    {
        Task<TModel> CreateAsync<TModel, TRequest>(
            TRequest? request,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        Task<TModel?> ReadAsync<TModel, TRequest>(
            TRequest? request,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        Task UpdateAsync<TModel, TRequest>(
            TRequest? request,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        Task DeleteAsync<TModel, TRequest>(
            TRequest? request,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        Task<IEnumerable<TModel>> ListAsync<TModel, TRequest>(
            TRequest? request,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;
    }
}
