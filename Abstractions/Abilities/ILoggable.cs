namespace Common.Abilities
{
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>An instance that can be logged.</summary>
    [PublicAPI]
    public interface ILoggable
    {
        /// <summary>Logs this instance.</summary>
        /// <returns>A task.</returns>
        Task Log();
    }
}
