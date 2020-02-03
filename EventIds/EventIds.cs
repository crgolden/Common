namespace Common
{
    using Microsoft.Extensions.Logging;

    /// <summary>Common event ids for logging.</summary>
    public static class EventIds
    {
        /// <summary>Gets the id for the starting get request event.</summary>
        /// <value>The id for the starting get request event.</value>
        public static EventId GetStart => new EventId(1000, nameof(GetStart));

        /// <summary>Gets the id for the ending get request event.</summary>
        /// <value>The id for the ending get request event.</value>
        public static EventId GetEnd => new EventId(1001, nameof(GetEnd));

        /// <summary>Gets the id for the ending ranged get request event.</summary>
        /// <value>The id for the ending ranged get request event.</value>
        public static EventId GetRangeStart => new EventId(1002, nameof(GetRangeStart));

        /// <summary>Gets the id for the ending ranged get request event.</summary>
        /// <value>The id for the ending ranged get request event.</value>
        public static EventId GetRangeEnd => new EventId(1003, nameof(GetRangeEnd));

        /// <summary>Gets the id for the starting create request event.</summary>
        /// <value>The id for the starting create request event.</value>
        public static EventId CreateStart => new EventId(1004, nameof(CreateStart));

        /// <summary>Gets the id for the ending create request event.</summary>
        /// <value>The id for the ending create request event.</value>
        public static EventId CreateEnd => new EventId(1005, nameof(CreateEnd));

        /// <summary>Gets the id for the ending ranged create request event.</summary>
        /// <value>The id for the ending ranged create request event.</value>
        public static EventId CreateRangeStart => new EventId(1006, nameof(CreateRangeStart));

        /// <summary>Gets the id for the ending ranged create request event.</summary>
        /// <value>The id for the ending ranged create request event.</value>
        public static EventId CreateRangeEnd => new EventId(1007, nameof(CreateRangeEnd));

        /// <summary>Gets the id for the starting update request event.</summary>
        /// <value>The id for the starting update request event.</value>
        public static EventId UpdateStart => new EventId(1008, nameof(UpdateStart));

        /// <summary>Gets the id for the ending update request event.</summary>
        /// <value>The id for the ending update request event.</value>
        public static EventId UpdateEnd => new EventId(1009, nameof(UpdateEnd));

        /// <summary>Gets the id for the ending ranged update request event.</summary>
        /// <value>The id for the ending ranged update request event.</value>
        public static EventId UpdateRangeStart => new EventId(1010, nameof(UpdateRangeStart));

        /// <summary>Gets the id for the ending ranged update request event.</summary>
        /// <value>The id for the ending ranged update request event.</value>
        public static EventId UpdateRangeEnd => new EventId(1011, nameof(UpdateRangeEnd));

        /// <summary>Gets the id for the starting delete request event.</summary>
        /// <value>The id for the starting delete request event.</value>
        public static EventId DeleteStart => new EventId(1012, nameof(DeleteStart));

        /// <summary>Gets the id for the ending delete request event.</summary>
        /// <value>The id for the ending delete request event.</value>
        public static EventId DeleteEnd => new EventId(1013, nameof(DeleteEnd));

        /// <summary>Gets the id for the ending ranged delete request event.</summary>
        /// <value>The id for the ending ranged delete request event.</value>
        public static EventId DeleteRangeStart => new EventId(1014, nameof(DeleteRangeStart));

        /// <summary>Gets the id for the ending ranged delete request event.</summary>
        /// <value>The id for the ending ranged delete request event.</value>
        public static EventId DeleteRangeEnd => new EventId(1015, nameof(DeleteRangeEnd));
    }
}
