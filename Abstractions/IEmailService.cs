namespace Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using static Microsoft.Extensions.Logging.LogLevel;

    public interface IEmailService
    {
        Task SendEmailAsync(
            string? source,
            IEnumerable<string>? destinations,
            string? subject,
            string? htmlBody,
            string? textBody = default,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);
    }
}
