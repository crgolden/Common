namespace Common
{
    using Microsoft.Extensions.Logging;

    public static class EventIds
    {
        public static EventId Exception => new EventId(1, nameof(Exception));

        /// <summary>
        /// 
        /// </summary>
        public static EventId GetRange => new EventId(2, nameof(GetRange));
    }
}
