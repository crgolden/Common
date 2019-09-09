namespace Common
{
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class StripePaymentOptions
    {
        public string SecretKey { get; set; }
    }
}