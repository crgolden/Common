namespace Common.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Abilities;
    using JetBrains.Annotations;

    /// <summary>A service that sends emails.</summary>
    [PublicAPI]
    public interface IEmailService : INameable
    {
        /// <summary>Sends an email.</summary>
        /// <param name="source">The source.</param>
        /// <param name="destinations">The destinations.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="htmlBody">The HTML body.</param>
        /// <param name="textBody">The text body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />
        /// or
        /// <paramref name="destinations"/> is <see langword="null" />
        /// or
        /// <paramref name="subject"/> is <see langword="null" />
        /// or
        /// <paramref name="htmlBody"/> is <see langword="null" />.</exception>
        Task SendEmailAsync(
            string source,
            IEnumerable<string> destinations,
            string subject,
            string htmlBody,
            string textBody = default,
            CancellationToken cancellationToken = default);
    }
}
