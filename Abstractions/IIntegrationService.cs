namespace Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IIntegrationService
    {
        Task<TModel> CreateAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class;

        Task<TModel> ReadAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class;

        Task UpdateAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class;

        Task DeleteAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class;

        Task<IEnumerable<TModel>> ListAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class;
    }
}
