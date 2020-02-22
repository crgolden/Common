namespace Common
{
    /// <summary>An instance that can be keyed.</summary>
    /// <typeparam name="T">The type of the key.</typeparam>
    public interface IKeyable<out T>
    {
        /// <summary>Gets the key.</summary>
        /// <value>The key.</value>
        T Key { get; }
    }
}
