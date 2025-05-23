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
    /// An actor that can bypass rules in a ruleset
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RepositoryRulesetBypassActor : IAdditionalDataHolder, IParsable
    {
        /// <summary>The ID of the actor that can bypass a ruleset. If `actor_type` is `OrganizationAdmin`, this should be `1`. If `actor_type` is `DeployKey`, this should be null. `OrganizationAdmin` is not applicable for personal repositories.</summary>
        public int? ActorId { get; set; }
        /// <summary>The type of actor that can bypass a ruleset.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_actor_type? ActorType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_bypass_mode? BypassMode { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor"/> and sets the default values.
        /// </summary>
        public RepositoryRulesetBypassActor()
        {
            AdditionalData = new Dictionary<string, object>();
            BypassMode = global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_bypass_mode.Always;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actor_id", n => { ActorId = n.GetIntValue(); } },
                { "actor_type", n => { ActorType = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_actor_type>(); } },
                { "bypass_mode", n => { BypassMode = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_bypass_mode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("actor_id", ActorId);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_actor_type>("actor_type", ActorType);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RepositoryRulesetBypassActor_bypass_mode>("bypass_mode", BypassMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
