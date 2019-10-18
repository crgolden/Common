namespace Common
{
    using System.Data.Common;

    public interface IDbService
    {
        DbServiceType Type { get; }

        string? Name { get; set; }

        bool CanCreateDataSourceEnumerator { get; }

        DbCommand CreateCommand();

        DbCommandBuilder CreateCommandBuilder();

        DbConnection CreateConnection();

        DbConnectionStringBuilder CreateConnectionStringBuilder();

        DbDataAdapter CreateDataAdapter();

        DbParameter CreateParameter();

        DbDataSourceEnumerator CreateDataSourceEnumerator();
    }
}
