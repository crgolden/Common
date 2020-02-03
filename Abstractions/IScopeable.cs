namespace Common
{
    using System;
    using JetBrains.Annotations;

    /// <summary>An instance that can be scoped.</summary>
    [PublicAPI]
    public interface IScopeable
    {
        /// <summary>Scopes this instance.</summary>
        /// <returns>The scope.</returns>
        IDisposable Scope();
    }
}
