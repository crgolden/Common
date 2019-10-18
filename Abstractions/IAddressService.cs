namespace Common
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IAddressService
    {
        Task<IEnumerable<Address>> ValidateAsync(
            Address? address,
            CancellationToken cancellationToken = default);
    }
}
