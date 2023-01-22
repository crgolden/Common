namespace Common.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Abilities;
    using JetBrains.Annotations;

    /// <summary>A service that validates an <see cref="Address"/>.</summary>
    [PublicAPI]
    public interface IAddressService : INameable
    {
        /// <summary>Validates an <see cref="Address"/>.</summary>
        /// <param name="address">The address.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A sequence of potential matches.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="address"/> is <see langword="null" />.</exception>
        Task<IEnumerable<Address>> ValidateAsync(Address address, CancellationToken cancellationToken = default);
    }
}
