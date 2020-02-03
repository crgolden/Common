namespace Common
{
    using System.Data.Common;
    using JetBrains.Annotations;

    /// <summary>Represents a set of methods for creating instances of a provider's implementation of the data source classes.</summary>
    [PublicAPI]
    public interface IDbService : INameable
    {
        /// <summary>Gets a value indicating whether the specific <see cref="IDbService" /> supports the <see cref="DbDataSourceEnumerator" /> class.</summary>
        /// <returns>
        /// <see langword="true" /> if the instance of the <see cref="IDbService" /> supports the <see cref="DbDataSourceEnumerator" /> class; otherwise <see langword="false" />.</returns>
        /// <value>
        /// A value indicating whether the specific <see cref="IDbService" /> supports the <see cref="DbDataSourceEnumerator" /> class.
        /// </value>
        bool CanCreateDataSourceEnumerator { get; }

        /// <summary>Gets a value indicating whether the specific <see cref="IDbService" /> supports the <see cref="DbDataAdapter" /> class.</summary>
        /// <returns>
        /// <see langword="true" /> if the instance of the <see cref="IDbService" /> supports the <see cref="DbDataAdapter" /> class; otherwise <see langword="false" />.</returns>
        /// <value>
        /// A value indicating whether the specific <see cref="IDbService" /> supports the <see cref="DbDataAdapter" /> class.
        /// </value>
        bool CanCreateDataAdapter { get; }

        /// <summary>Gets a value indicating whether the specific <see cref="IDbService" /> supports the <see cref="DbCommandBuilder" /> class.</summary>
        /// <returns>
        /// <see langword="true" /> if the instance of the <see cref="IDbService" /> supports the <see cref="DbCommandBuilder" /> class; otherwise <see langword="false" />.</returns>
        /// <value>
        /// A value indicating whether the specific <see cref="IDbService" /> supports the <see cref="DbCommandBuilder" /> class.
        /// </value>
        bool CanCreateCommandBuilder { get; }

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbCommand" /> class.</summary>
        /// <returns>A new instance of <see cref="DbCommand" />.</returns>
        DbCommand CreateCommand();

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbCommandBuilder" /> class.</summary>
        /// <returns>A new instance of <see cref="DbCommandBuilder" />.</returns>
        DbCommandBuilder CreateCommandBuilder();

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbConnection" /> class.</summary>
        /// <returns>A new instance of <see cref="DbConnection" />.</returns>
        DbConnection CreateConnection();

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbConnectionStringBuilder" /> class.</summary>
        /// <returns>A new instance of <see cref="DbConnectionStringBuilder" />.</returns>
        DbConnectionStringBuilder CreateConnectionStringBuilder();

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbDataAdapter" /> class.</summary>
        /// <returns>A new instance of <see cref="DbDataAdapter" />.</returns>
        DbDataAdapter CreateDataAdapter();

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbDataSourceEnumerator" /> class.</summary>
        /// <returns>A new instance of <see cref="DbDataSourceEnumerator" />.</returns>
        DbDataSourceEnumerator CreateDataSourceEnumerator();

        /// <summary>Returns a new instance of the provider's class that implements the <see cref="DbParameter" /> class.</summary>
        /// <returns>A new instance of <see cref="DbParameter" />.</returns>
        DbParameter CreateParameter();
    }
}
