namespace Common
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    /// <summary>This is a convenience class to strongly type the <a href="https://openid.net/specs/openid-connect-core-1_0.html#AddressClaim">Address Claim</a>.</summary>
    [PublicAPI]
    public class Address
    {
        /// <summary>Gets the full mailing address.</summary>
        /// <value>
        /// Full mailing address, formatted for display or use on a mailing label.
        /// This field MAY contain multiple lines, separated by newlines.
        /// Newlines can be represented either as a carriage return/line feed pair ("\r\n")
        /// or as a single line feed character("\n").
        /// </value>
        [JsonPropertyName("formatted")]
        public string Formatted => @$"
                                      {StreetAddress.Trim()}
                                      {Locality.Trim()}
                                      {$"{Region.Trim()} {PostalCode.Trim()}"}
                                      {Country.Trim()}
                                     ".Trim();

        /// <summary>Gets or sets the full street address.</summary>
        /// <value>
        /// Full street address component, which MAY include house number, street name,
        /// Post Office Box, and multi-line extended street address information.
        /// This field MAY contain multiple lines, separated by newlines.
        /// Newlines can be represented either as a carriage return/line feed pair ("\r\n")
        /// or as a single line feed character("\n").
        /// </value>
        [JsonPropertyName("street_address")]
        public string StreetAddress { get; set; }

        /// <summary>Gets or sets the locality.</summary>
        /// <value>City or locality component.</value>
        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        /// <summary>Gets or sets the state or region.</summary>
        /// <value>State, province, prefecture, or region component.</value>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>Gets or sets the zip or postal code.</summary>
        /// <value>Zip code or postal code component.</value>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>Gets or sets the country.</summary>
        /// <value>Country name component.</value>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
