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
    public partial class RuleSuite_rule_evaluations : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The detailed failure message for the rule. Null if the rule passed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Details { get; set; }
#nullable restore
#else
        public string Details { get; set; }
#endif
        /// <summary>The enforcement level of this rule source.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_enforcement? Enforcement { get; set; }
        /// <summary>The result of the evaluation of the individual rule.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_result? Result { get; set; }
        /// <summary>The rule_source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_rule_source? RuleSource { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_rule_source RuleSource { get; set; }
#endif
        /// <summary>The type of rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleType { get; set; }
#nullable restore
#else
        public string RuleType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations"/> and sets the default values.
        /// </summary>
        public RuleSuite_rule_evaluations()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "details", n => { Details = n.GetStringValue(); } },
                { "enforcement", n => { Enforcement = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_enforcement>(); } },
                { "result", n => { Result = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_result>(); } },
                { "rule_source", n => { RuleSource = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_rule_source>(global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_rule_source.CreateFromDiscriminatorValue); } },
                { "rule_type", n => { RuleType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("details", Details);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_enforcement>("enforcement", Enforcement);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_result>("result", Result);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.RuleSuite_rule_evaluations_rule_source>("rule_source", RuleSource);
            writer.WriteStringValue("rule_type", RuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
