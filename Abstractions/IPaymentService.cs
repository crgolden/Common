namespace Common
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>A service that processes payments.</summary>
    [PublicAPI]
    public interface IPaymentService
    {
        /// <summary>Gets a customer by identifier.</summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The customer.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="customerId" /> is <see langword="null" />.</exception>
        Task<string> GetCustomerAsync(
            string customerId,
            CancellationToken cancellationToken = default);

        /// <summary>Creates a customer.</summary>
        /// <param name="email">The email.</param>
        /// <param name="tokenId">The token identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The customer.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="email" /> is <see langword="null" />
        /// or
        /// <paramref name="tokenId"/> is <see langword="null" />.</exception>
        Task<string> CreateCustomerAsync(
            string email,
            string tokenId,
            CancellationToken cancellationToken = default);

        /// <summary>Authorizes a payment.</summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="currency">The currency.</param>
        /// <param name="description">The description.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The authorization code.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="customerId" /> is <see langword="null" />
        /// or
        /// <paramref name="amount"/> is <see langword="null" />
        /// or
        /// <paramref name="currency"/> is <see langword="null" />.</exception>
        Task<string> AuthorizeAsync(
            string customerId,
            decimal amount,
            string currency,
            string description = default,
            CancellationToken cancellationToken = default);

        /// <summary>Captures a payment.</summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="currency">The currency.</param>
        /// <param name="description">The description.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The capture code.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="customerId" /> is <see langword="null" />
        /// or
        /// <paramref name="amount"/> is <see langword="null" />
        /// or
        /// <paramref name="currency"/> is <see langword="null" />.</exception>
        Task<string> CaptureAsync(
            string customerId,
            decimal amount,
            string currency,
            string description = default,
            CancellationToken cancellationToken = default);

        /// <summary>Updates a payment description.</summary>
        /// <param name="chargeId">The charge identifier.</param>
        /// <param name="description">The description.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="chargeId" /> is <see langword="null" />.</exception>
        Task UpdateAsync(
            string chargeId,
            string description,
            CancellationToken cancellationToken = default);
    }
}
