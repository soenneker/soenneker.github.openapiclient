// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WithSecret_namePatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptedValue { get; set; }
#nullable restore
#else
        public string EncryptedValue { get; set; }
#endif
        /// <summary>The ID of the key you used to encrypt the secret.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>The registry type.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody_registry_type? RegistryType { get; set; }
        /// <summary>An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. This field should be omitted if `visibility` is set to `all` or `private`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? SelectedRepositoryIds { get; set; }
#nullable restore
#else
        public List<int?> SelectedRepositoryIds { get; set; }
#endif
        /// <summary>The username to use when authenticating with the private registry. This field should be omitted if the private registry does not require a username for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody_visibility? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithSecret_namePatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "encrypted_value", n => { EncryptedValue = n.GetStringValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
                { "registry_type", n => { RegistryType = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody_registry_type>(); } },
                { "selected_repository_ids", n => { SelectedRepositoryIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "username", n => { Username = n.GetStringValue(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody_visibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("encrypted_value", EncryptedValue);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody_registry_type>("registry_type", RegistryType);
            writer.WriteCollectionOfPrimitiveValues<int?>("selected_repository_ids", SelectedRepositoryIds);
            writer.WriteStringValue("username", Username);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.PrivateRegistries.Item.WithSecret_namePatchRequestBody_visibility>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
