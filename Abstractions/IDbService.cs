namespace Common
{
    using System.Data.Common;

    public interface IDbService
    {
        DbProviderType Provider { get; }

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
