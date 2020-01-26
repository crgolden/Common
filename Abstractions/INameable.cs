namespace Common
{
    /// <summary>An implementation that can be identified by name.</summary>
    public interface INameable
    {
        /// <summary>Gets the name of the implementation.</summary>
        /// <value>The name of the implementation.</value>
        string Name { get; }
    }
}
