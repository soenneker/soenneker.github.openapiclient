// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    /// <summary>
    /// Organization roles
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OrganizationRole : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The system role from which this role inherits permissions.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole_base_role? BaseRole { get; set; }
        /// <summary>The date and time the role was created.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>A short description about who this role is for or what permissions it grants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The unique identifier of the role.</summary>
        public long? Id { get; set; }
        /// <summary>The name of the role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The organization property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser? Organization { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser Organization { get; set; }
#endif
        /// <summary>A list of permissions included in this role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Permissions { get; set; }
#nullable restore
#else
        public List<string> Permissions { get; set; }
#endif
        /// <summary>Source answers the question, &quot;where did this role come from?&quot;</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole_source? Source { get; set; }
        /// <summary>The date and time the role was last updated.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole"/> and sets the default values.
        /// </summary>
        public OrganizationRole()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "base_role", n => { BaseRole = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole_base_role>(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "organization", n => { Organization = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "permissions", n => { Permissions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "source", n => { Source = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole_source>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole_base_role>("base_role", BaseRole);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("description", Description);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>("organization", Organization);
            writer.WriteCollectionOfPrimitiveValues<string>("permissions", Permissions);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.OrganizationRole_source>("source", Source);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
