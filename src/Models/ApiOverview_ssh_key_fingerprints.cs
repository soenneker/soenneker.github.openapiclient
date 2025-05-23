// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ApiOverview_ssh_key_fingerprints : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The SHA256_DSA property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SHA256DSA { get; set; }
#nullable restore
#else
        public string SHA256DSA { get; set; }
#endif
        /// <summary>The SHA256_ECDSA property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SHA256ECDSA { get; set; }
#nullable restore
#else
        public string SHA256ECDSA { get; set; }
#endif
        /// <summary>The SHA256_ED25519 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SHA256ED25519 { get; set; }
#nullable restore
#else
        public string SHA256ED25519 { get; set; }
#endif
        /// <summary>The SHA256_RSA property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SHA256RSA { get; set; }
#nullable restore
#else
        public string SHA256RSA { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.ApiOverview_ssh_key_fingerprints"/> and sets the default values.
        /// </summary>
        public ApiOverview_ssh_key_fingerprints()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.ApiOverview_ssh_key_fingerprints"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.ApiOverview_ssh_key_fingerprints CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.ApiOverview_ssh_key_fingerprints();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "SHA256_DSA", n => { SHA256DSA = n.GetStringValue(); } },
                { "SHA256_ECDSA", n => { SHA256ECDSA = n.GetStringValue(); } },
                { "SHA256_ED25519", n => { SHA256ED25519 = n.GetStringValue(); } },
                { "SHA256_RSA", n => { SHA256RSA = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("SHA256_DSA", SHA256DSA);
            writer.WriteStringValue("SHA256_ECDSA", SHA256ECDSA);
            writer.WriteStringValue("SHA256_ED25519", SHA256ED25519);
            writer.WriteStringValue("SHA256_RSA", SHA256RSA);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
