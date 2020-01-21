namespace Common
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IPaymentService
    {
        Task<string> GetCustomerAsync(
            string customerId,
            CancellationToken cancellationToken = default);

        Task<string> CreateCustomerAsync(
            string email,
            string tokenId,
            CancellationToken cancellationToken = default);

        Task<string> AuthorizeAsync(
            string customerId,
            decimal amount,
            string currency,
            string description = default,
            CancellationToken cancellationToken = default);

        Task<string> CaptureAsync(
            string customerId,
            decimal amount,
            string currency,
            string description = default,
            CancellationToken cancellationToken = default);

        Task UpdateAsync(
            string chargeId,
            string description,
            CancellationToken cancellationToken = default);
    }
}
