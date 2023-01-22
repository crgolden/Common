namespace Common.Services
{
    using JetBrains.Annotations;

    /// <summary>A service that reads and writes data.</summary>
    [PublicAPI]
    public interface IDataService : IDataCommandService, IDataQueryService
    {
    }
}
