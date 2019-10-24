namespace Common
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Extensions.Logging;
    using static Moq.It;

    public static class EventIdExtensions
    {
        public static Expression<Action<ILogger>> IsLoggedWith(
            this EventId eventId,
            LogLevel logLevel,
            Exception? exception = default)
        {
            return logger => logger.Log(
                logLevel,
                Is<Microsoft.Extensions.Logging.EventId>(y => y.Id == (int)eventId && y.Name == $"{eventId}"),
                IsAny<IsAnyType>(),
                exception,
                (Func<IsAnyType, Exception, string>)IsAny<object>());
        }
    }
}
