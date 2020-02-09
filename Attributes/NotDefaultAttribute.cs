namespace Common
{
    using System.ComponentModel.DataAnnotations;
    using JetBrains.Annotations;
    using static System.Activator;

    /// <summary>An attribute to ensure a value type doesn't have the default value.</summary>
    [PublicAPI]
    public class NotDefaultAttribute : ValidationAttribute
    {
        /// <summary>The default error message.</summary>
        public const string DefaultErrorMessage = "The {0} field must not have the default value";

        /// <summary>
        /// Initializes a new instance of the <see cref="NotDefaultAttribute"/> class.
        /// </summary>
        public NotDefaultAttribute()
            : base(DefaultErrorMessage)
        {
        }

        /// <inheritdoc />
        public override bool IsValid(object value)
        {
            if (value is null)
            {
                return true;
            }

            var type = value.GetType();
            if (!type.IsValueType)
            {
                return true;
            }

            var defaultValue = CreateInstance(type);
            return !value.Equals(defaultValue);
        }
    }
}
