namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>A service that updates data.</summary>
    [PublicAPI]
    public interface IDataCommandService : INameable
    {
        /// <summary>Creates a record.</summary>
        /// <typeparam name="T">The type of <paramref name="record"/>.</typeparam>
        /// <param name="record">The record to create.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{T}"/>.</returns>
        Task<T> CreateAsync<T>(T record, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>Creates a sequence of records.</summary>
        /// <typeparam name="T">The type of <paramref name="records"/>.</typeparam>
        /// <param name="records">The record to create.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{IEnumerable}"/>.</returns>
        Task<IEnumerable<T>> CreateRangeAsync<T>(IEnumerable<T> records, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>Deletes a record.</summary>
        /// <typeparam name="T">The type of the record.</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task DeleteAsync<T>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>Deletes a sequence of records.</summary>
        /// <typeparam name="T">The type of the records.</typeparam>
        /// <param name="keyValuePairs">The predicate.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task DeleteRangeAsync<T>(IDictionary<Expression<Func<T, bool>>, T> keyValuePairs, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>Finds a single element by its key value(s).</summary>
        /// <param name="keyValues">The key values of the element to be returned.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <typeparam name="T">The type of the element with key values <paramref name="keyValues"/>/>.</typeparam>
        /// <returns>The element with the specified <paramref name="keyValues"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="keyValues"/> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException"><paramref name="keyValues"/> is empty.</exception>
        ValueTask<T> GetAsync<T>(object[] keyValues, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>Persists changes to the store.</summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>Updates a record.</summary>
        /// <typeparam name="T">The type of <paramref name="record"/>.</typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <param name="record">The record to update.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task UpdateAsync<T>(Expression<Func<T, bool>> predicate, T record, CancellationToken cancellationToken = default)
            where T : class;

        /// <summary>
        /// Updates a sequence of records.</summary>
        /// <typeparam name="T">The type of the records/>.</typeparam>
        /// <param name="keyValuePairs">The predicate/records pairs.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task UpdateRangeAsync<T>(IDictionary<Expression<Func<T, bool>>, T> keyValuePairs, CancellationToken cancellationToken = default)
            where T : class;
    }
}
