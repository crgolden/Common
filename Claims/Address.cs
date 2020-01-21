namespace Common
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    /// <include file='docs.xml' path='docs/members[@name="address"]/Address/*'/>
    // https://openid.net/specs/openid-connect-core-1_0.html#AddressClaim
    [PublicAPI]
    public class Address
    {
        /// <include file='docs.xml' path='docs/members[@name="address"]/Formatted/*'/>
        [JsonPropertyName("formatted")]
        public string Formatted => $"{StreetAddress}\r\n{Locality}\r\n{Region} {PostalCode}\r\n{Country}";

        /// <include file='docs.xml' path='docs/members[@name="address"]/StreetAddress/*'/>
        [JsonPropertyName("street_address")]
        public string StreetAddress { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="address"]/Locality/*'/>
        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="address"]/Region/*'/>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="address"]/PostalCode/*'/>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <include file='docs.xml' path='docs/members[@name="address"]/Country/*'/>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
