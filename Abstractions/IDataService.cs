namespace Common
{
    using JetBrains.Annotations;

    /// <summary>A service that both reads and updates data.</summary>
    [PublicAPI]
    public interface IDataService : IDataCommandService, IDataQueryService
    {
    }
}
