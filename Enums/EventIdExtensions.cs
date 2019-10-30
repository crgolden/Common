namespace Common
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Extensions.Logging;
    using Moq;

    public static class EventIdExtensions
    {
        public static Expression<Action<ILogger>> IsLoggedWith(
            this EventId eventId,
            LogLevel logLevel,
            Exception? exception = default)
        {
            return logger => logger.Log(
                logLevel,
                It.Is<Microsoft.Extensions.Logging.EventId>(x => x.Id == (int)eventId && x.Name == $"{eventId}"),
                It.IsAny<It.IsAnyType>(),
                exception,
                (Func<It.IsAnyType, Exception, string>)It.IsAny<object>());
        }
    }
}
