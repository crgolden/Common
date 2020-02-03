namespace Common
{
    using JetBrains.Annotations;

    /// <summary>An instance that can be named.</summary>
    [PublicAPI]
    public interface INameable
    {
        /// <summary>Gets the name of this instance.</summary>
        /// <value>The name.</value>
        string Name { get; }
    }
}
