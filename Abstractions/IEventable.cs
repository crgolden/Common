namespace Common
{
    using Microsoft.Extensions.Logging;

    public interface IEventable
    {
        EventId EventId { get; }
    }
}
