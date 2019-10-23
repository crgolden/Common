namespace Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using static Microsoft.Extensions.Logging.LogLevel;

    public interface IAddressService
    {
        Task<IEnumerable<Address>> ValidateAsync(
            Address? address,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);
    }
}
