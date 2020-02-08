namespace Common
{
    using System;
    using JetBrains.Annotations;

    /// <summary>An instance that can be scoped.</summary>
    [PublicAPI]
    public interface IScopeable
    {
        /// <summary>Gets the scope.</summary>
        /// <value>The scope.</value>
        IDisposable Scope { get; }
    }
}
