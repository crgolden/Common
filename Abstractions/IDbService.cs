namespace Common
{
    using System.Data;

    public interface IDbService
    {
        string Provider { get; }

        IDbConnection GetConnection();

        IDbDataAdapter GetDataAdapter(string commandText);
    }
}
