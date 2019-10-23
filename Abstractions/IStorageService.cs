namespace Common
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using static Microsoft.Extensions.Logging.LogLevel;

    public interface IStorageService
    {
        Task<Uri> Upload(
            Stream? stream,
            string? fileName,
            string? folderName,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Task Delete(
            string? fileName,
            string? folderName,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Task DeleteAll(
            string? folderName,
            LogLevel logLevel = Information,
            CancellationToken cancellationToken = default);

        Uri GetUrl(
            string? fileName,
            string? folderName,
            DateTime? expiration,
            LogLevel logLevel = Trace);
    }
}