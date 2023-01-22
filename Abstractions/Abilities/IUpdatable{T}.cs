namespace Common.Abilities
{
    using System;
    using JetBrains.Annotations;

    /// <summary>An instance that can be updated.</summary>
    /// <typeparam name="T">The type of the identifier.</typeparam>
    [PublicAPI]
    public interface IUpdatable<T>
    {
        /// <summary>Gets or sets the created by.</summary>
        /// <value>The created by.</value>
        T UpdatedBy { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        DateTimeOffset UpdatedDate { get; set; }
    }
}
