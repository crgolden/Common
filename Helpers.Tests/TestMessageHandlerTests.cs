﻿namespace Common.Helpers.Tests
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Xunit;
    using static System.Net.HttpStatusCode;
    using static System.Threading.CancellationToken;

    public class TestMessageHandlerTests
    {
        [Fact]
        public void ThrowsForNullHandler()
        {
            // Arrange
            static DerivedMessageHandler DefaultTestCode() => new (default);

            // Act
            var exception = Assert.Throws<ArgumentNullException>(DefaultTestCode);

            // Assert
            Assert.Equal("handler", exception.ParamName);
        }

        [Fact]
        public async Task SendAsyncThrowsForNullRequest()
        {
            // Act
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(TestCode).ConfigureAwait(true);

            // Assert
            Assert.Equal("request", exception.ParamName);
        }

        [Fact]
        public async Task SendAsync()
        {
            // Arrange
            HttpResponseMessage response;

            // Act
            using (var handler = new DerivedMessageHandler(_ => new HttpResponseMessage(OK)))
            {
                using var request = new HttpRequestMessage();
                response = await handler.SendAsyncForTest(request).ConfigureAwait(true);
            }

            // Assert
            Assert.Equal(OK, response.StatusCode);
        }

        private static Task TestCode()
        {
            using var handler = new DerivedMessageHandler(_ => new HttpResponseMessage(OK));
            return handler.SendAsyncForTest(default);
        }

        private class DerivedMessageHandler : TestMessageHandler
        {
            public DerivedMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> handler)
                : base(handler)
            {
            }

            public Task<HttpResponseMessage> SendAsyncForTest(HttpRequestMessage request) => SendAsync(request, None);
        }
   }
}
