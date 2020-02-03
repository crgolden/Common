namespace Common
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>A service that manages file storage.</summary>
    public interface IStorageService
    {
        /// <summary>Uploads the specified stream.</summary>
        /// <param name="stream">The stream.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="Uri"/> of the uploaded file.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is <see langword="null" />
        /// or
        /// <paramref name="fileName"/> is <see langword="null" />
        /// or
        /// <paramref name="folderName"/> is <see langword="null" />.</exception>
        Task<Uri> Upload(
            Stream stream,
            string fileName,
            string folderName,
            CancellationToken cancellationToken = default);

        /// <summary>Deletes the specified file.</summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="fileName"/> is <see langword="null" />
        /// or
        /// <paramref name="folderName"/> is <see langword="null" />.</exception>
        Task Delete(
            string fileName,
            string folderName,
            CancellationToken cancellationToken = default);

        /// <summary>Deletes all.</summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="folderName"/> is <see langword="null" />.</exception>
        Task DeleteAll(
            string folderName,
            CancellationToken cancellationToken = default);

        /// <summary>Gets as secure URL.</summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="expiration">The expiration.</param>
        /// <returns>The secure URL.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="fileName"/> is <see langword="null" />
        /// or
        /// <paramref name="folderName"/> is <see langword="null" />.</exception>
        Uri GetUrl(
            string fileName,
            string folderName,
            DateTime expiration);
    }
}
