namespace Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IEmailService
    {
        Task SendEmailAsync(
            string? source,
            IEnumerable<string>? destinations,
            string? subject,
            string? htmlBody,
            string? textBody = default,
            CancellationToken cancellationToken = default);
    }
}
