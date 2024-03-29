﻿namespace Common.Abilities
{
    using System;
    using JetBrains.Annotations;

    /// <summary>An instance that can be created.</summary>
    /// <typeparam name="T">The type of the identifier.</typeparam>
    [PublicAPI]
    public interface ICreatable<T>
    {
        /// <summary>Gets or sets the created by.</summary>
        /// <value>The created by.</value>
        T CreatedBy { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        DateTimeOffset CreatedDate { get; set; }
    }
}
