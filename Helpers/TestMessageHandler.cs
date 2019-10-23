namespace Common
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using static System.Threading.Tasks.Task;

    public class TestMessageHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _handler;

        public TestMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> handler)
        {
            _handler = handler;
        }

        /// <inheritdoc />
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return FromResult(_handler(request));
        }
    }
}
