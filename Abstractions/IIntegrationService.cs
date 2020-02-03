namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>A service that integrates with another system.</summary>
    [PublicAPI]
    public interface IIntegrationService
    {
        /// <summary>Creates a <typeparamref name="TModel"/>.</summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <typeparamref name="TModel"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="request" /> is <see langword="null" />.</exception>
        Task<TModel> CreateAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        /// <summary>Reads a <typeparamref name="TModel"/>.</summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <typeparamref name="TModel"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="request" /> is <see langword="null" />.</exception>
        Task<TModel> ReadAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        /// <summary>Updates a <typeparamref name="TModel"/>.</summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="request" /> is <see langword="null" />.</exception>
        Task UpdateAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        /// <summary>Deletes a <typeparamref name="TModel"/>.</summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="request" /> is <see langword="null" />.</exception>
        Task DeleteAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;

        /// <summary>Returns a sequence containing <typeparamref name="TModel"/>.</summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The sequence containing <typeparamref name="TModel"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="request" /> is <see langword="null" />.</exception>
        Task<IEnumerable<TModel>> ListAsync<TModel, TRequest>(
            TRequest request,
            CancellationToken cancellationToken = default)
            where TModel : class
            where TRequest : class;
    }
}
