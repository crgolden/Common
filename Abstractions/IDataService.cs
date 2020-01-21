namespace Common
{
    /// <summary>A service that both reads and updates data.</summary>
    public interface IDataService : IDataCommandService, IDataQueryService
    {
    }
}
