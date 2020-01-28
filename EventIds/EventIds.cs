namespace Common
{
    using Microsoft.Extensions.Logging;

    public static class EventIds
    {
        /// <summary>
        /// 
        /// </summary>
        public static EventId Query => new EventId(1000, nameof(Query));
    }
}
