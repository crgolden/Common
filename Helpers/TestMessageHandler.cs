namespace Common
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;
    using static System.Threading.Tasks.Task;

    /// <summary>A helper for testing the <see cref="HttpClient"/>.</summary>
    [PublicAPI]
    public class TestMessageHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _handler;

        /// <summary>Initializes a new instance of the <see cref="TestMessageHandler"/> class.</summary>
        /// <param name="handler">The handler.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handler" /> is <see langword="null" />.</exception>
        public TestMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> handler)
        {
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        /// <inheritdoc />
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request == default)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return FromResult(_handler(request));
        }
    }
}
