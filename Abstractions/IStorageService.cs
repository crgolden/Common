namespace Common
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IStorageService
    {
        Task<Uri> Upload(
            Stream stream,
            string fileName,
            string folderName,
            CancellationToken cancellationToken = default);

        Task Delete(
            string fileName,
            string folderName,
            CancellationToken cancellationToken = default);

        Task DeleteAll(
            string folderName,
            CancellationToken cancellationToken = default);

        Uri GetUrl(
            string fileName,
            string folderName,
            DateTime expiration);
    }
}