// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WithUsernamePutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The permission to grant the collaborator.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody_permission? Permission { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody"/> and sets the default values.
        /// </summary>
        public WithUsernamePutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Permission = global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody_permission.Write;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "permission", n => { Permission = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody_permission>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Projects.Item.Collaborators.Item.WithUsernamePutRequestBody_permission>("permission", Permission);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
