namespace Common
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using static Microsoft.Extensions.Logging.LogLevel;

    public interface IPaymentService
    {
        Task<string?> GetCustomerAsync(
            string? customerId,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Task<string?> CreateCustomerAsync(
            string? email,
            string? tokenId,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Task<string?> AuthorizeAsync(
            string? customerId,
            decimal? amount,
            string? currency,
            string? description = default,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Task<string?> CaptureAsync(
            string? customerId,
            decimal? amount,
            string? currency,
            string? description = default,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Task UpdateAsync(
            string? chargeId,
            string? description,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);
    }
}
