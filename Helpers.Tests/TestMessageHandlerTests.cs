namespace Common.Helpers.Tests
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;
    using static System.Net.HttpStatusCode;

    public class TestMessageHandlerTests
    {
        [Fact]
        public void ThrowsForNullHandler()
        {
            // Arrange
            static object TestCode() => new DerivedMessageHandler(default);

            // Act
            var exception = Assert.Throws<ArgumentNullException>(TestCode);

            // Assert
            Assert.Equal("handler", exception.ParamName);
        }

        [Fact]
        public async Task SendAsyncThrowsForNullRequest()
        {
            // Arrange
            ArgumentNullException exception;

            // Act
            using (var responseMessage = new HttpResponseMessage())
            {
                HttpResponseMessage Handler(HttpRequestMessage requestMessage) => responseMessage;
                using var messageHandler = new DerivedMessageHandler(Handler);
                Task TestCode() => messageHandler.SendAsyncForTest(default);
                exception = await Assert.ThrowsAsync<ArgumentNullException>(TestCode).ConfigureAwait(false);
            }

            // Assert
            Assert.Equal("request", exception.ParamName);
        }

        [Fact]
        public async Task SendAsync()
        {
            // Arrange
            HttpResponseMessage response;

            // Act
            using (var responseMessage = new HttpResponseMessage(OK))
            {
                HttpResponseMessage Handler(HttpRequestMessage requestMessage) => responseMessage;
                using var messageHandler = new DerivedMessageHandler(Handler);
                using (var requestMessage = new HttpRequestMessage())
                {
                    response = await messageHandler.SendAsyncForTest(requestMessage).ConfigureAwait(false);
                }
            }

            // Assert
            Assert.Equal(OK, response.StatusCode);
        }

        private class DerivedMessageHandler : TestMessageHandler
        {
            public DerivedMessageHandler(Func<HttpRequestMessage, HttpResponseMessage>? handler)
                : base(handler)
            {
            }

            public Task<HttpResponseMessage> SendAsyncForTest(HttpRequestMessage? request)
            {
                return SendAsync(request, CancellationToken.None);
            }
        }
    }
}
