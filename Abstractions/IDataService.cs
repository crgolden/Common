namespace Common
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDataService
    {
        DataServiceType Type { get; }

        string? Name { get; set; }

        Task<T> CreateAsync<T>(
            T? record,
            CancellationToken cancellationToken = default)
            where T : class;

        Task<T?> ReadAsync<T>(
            Expression<Func<T, bool>>? expression,
            CancellationToken cancellationToken = default)
            where T : class;

        Task UpdateAsync<T>(
            Expression<Func<T, bool>>? expression,
            T? record,
            CancellationToken cancellationToken = default)
            where T : class;

        Task DeleteAsync<T>(
            Expression<Func<T, bool>>? expression,
            CancellationToken cancellationToken = default)
            where T : class;

        IQueryable<T> List<T>()
            where T : class;
    }
}
