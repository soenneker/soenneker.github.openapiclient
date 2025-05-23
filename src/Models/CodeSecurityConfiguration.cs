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
    /// A code security configuration
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CodeSecurityConfiguration : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enablement status of GitHub Advanced Security</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_advanced_security? AdvancedSecurity { get; set; }
        /// <summary>The enablement status of code scanning default setup</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup? CodeScanningDefaultSetup { get; set; }
        /// <summary>Feature options for code scanning default setup</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup_options? CodeScanningDefaultSetupOptions { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup_options CodeScanningDefaultSetupOptions { get; set; }
#endif
        /// <summary>The enablement status of code scanning delegated alert dismissal</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_delegated_alert_dismissal? CodeScanningDelegatedAlertDismissal { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The enablement status of Dependabot alerts</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependabot_alerts? DependabotAlerts { get; set; }
        /// <summary>The enablement status of Dependabot security updates</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependabot_security_updates? DependabotSecurityUpdates { get; set; }
        /// <summary>The enablement status of Dependency Graph</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph? DependencyGraph { get; set; }
        /// <summary>The enablement status of Automatic dependency submission</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action? DependencyGraphAutosubmitAction { get; set; }
        /// <summary>Feature options for Automatic dependency submission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action_options? DependencyGraphAutosubmitActionOptions { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action_options DependencyGraphAutosubmitActionOptions { get; set; }
#endif
        /// <summary>A description of the code security configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The enforcement status for a security configuration</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_enforcement? Enforcement { get; set; }
        /// <summary>The URL of the configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The ID of the code security configuration</summary>
        public int? Id { get; set; }
        /// <summary>The name of the code security configuration. Must be unique within the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The enablement status of private vulnerability reporting</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_private_vulnerability_reporting? PrivateVulnerabilityReporting { get; set; }
        /// <summary>The enablement status of secret scanning</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning? SecretScanning { get; set; }
        /// <summary>The enablement status of secret scanning delegated alert dismissal</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_alert_dismissal? SecretScanningDelegatedAlertDismissal { get; set; }
        /// <summary>The enablement status of secret scanning delegated bypass</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass? SecretScanningDelegatedBypass { get; set; }
        /// <summary>Feature options for secret scanning delegated bypass</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass_options? SecretScanningDelegatedBypassOptions { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass_options SecretScanningDelegatedBypassOptions { get; set; }
#endif
        /// <summary>The enablement status of Copilot secret scanning</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_generic_secrets? SecretScanningGenericSecrets { get; set; }
        /// <summary>The enablement status of secret scanning non-provider patterns</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_non_provider_patterns? SecretScanningNonProviderPatterns { get; set; }
        /// <summary>The enablement status of secret scanning push protection</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_push_protection? SecretScanningPushProtection { get; set; }
        /// <summary>The enablement status of secret scanning validity checks</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_validity_checks? SecretScanningValidityChecks { get; set; }
        /// <summary>The type of the code security configuration.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_target_type? TargetType { get; set; }
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The URL of the configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration"/> and sets the default values.
        /// </summary>
        public CodeSecurityConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security", n => { AdvancedSecurity = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_advanced_security>(); } },
                { "code_scanning_default_setup", n => { CodeScanningDefaultSetup = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup>(); } },
                { "code_scanning_default_setup_options", n => { CodeScanningDefaultSetupOptions = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup_options>(global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup_options.CreateFromDiscriminatorValue); } },
                { "code_scanning_delegated_alert_dismissal", n => { CodeScanningDelegatedAlertDismissal = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_delegated_alert_dismissal>(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "dependabot_alerts", n => { DependabotAlerts = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependabot_alerts>(); } },
                { "dependabot_security_updates", n => { DependabotSecurityUpdates = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependabot_security_updates>(); } },
                { "dependency_graph", n => { DependencyGraph = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph>(); } },
                { "dependency_graph_autosubmit_action", n => { DependencyGraphAutosubmitAction = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action>(); } },
                { "dependency_graph_autosubmit_action_options", n => { DependencyGraphAutosubmitActionOptions = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action_options>(global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action_options.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "enforcement", n => { Enforcement = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_enforcement>(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "private_vulnerability_reporting", n => { PrivateVulnerabilityReporting = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_private_vulnerability_reporting>(); } },
                { "secret_scanning", n => { SecretScanning = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning>(); } },
                { "secret_scanning_delegated_alert_dismissal", n => { SecretScanningDelegatedAlertDismissal = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_alert_dismissal>(); } },
                { "secret_scanning_delegated_bypass", n => { SecretScanningDelegatedBypass = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass>(); } },
                { "secret_scanning_delegated_bypass_options", n => { SecretScanningDelegatedBypassOptions = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass_options>(global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass_options.CreateFromDiscriminatorValue); } },
                { "secret_scanning_generic_secrets", n => { SecretScanningGenericSecrets = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_generic_secrets>(); } },
                { "secret_scanning_non_provider_patterns", n => { SecretScanningNonProviderPatterns = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_non_provider_patterns>(); } },
                { "secret_scanning_push_protection", n => { SecretScanningPushProtection = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_push_protection>(); } },
                { "secret_scanning_validity_checks", n => { SecretScanningValidityChecks = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_validity_checks>(); } },
                { "target_type", n => { TargetType = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_target_type>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_advanced_security>("advanced_security", AdvancedSecurity);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup>("code_scanning_default_setup", CodeScanningDefaultSetup);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_default_setup_options>("code_scanning_default_setup_options", CodeScanningDefaultSetupOptions);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_code_scanning_delegated_alert_dismissal>("code_scanning_delegated_alert_dismissal", CodeScanningDelegatedAlertDismissal);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependabot_alerts>("dependabot_alerts", DependabotAlerts);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependabot_security_updates>("dependabot_security_updates", DependabotSecurityUpdates);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph>("dependency_graph", DependencyGraph);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action>("dependency_graph_autosubmit_action", DependencyGraphAutosubmitAction);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_dependency_graph_autosubmit_action_options>("dependency_graph_autosubmit_action_options", DependencyGraphAutosubmitActionOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_enforcement>("enforcement", Enforcement);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_private_vulnerability_reporting>("private_vulnerability_reporting", PrivateVulnerabilityReporting);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning>("secret_scanning", SecretScanning);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_alert_dismissal>("secret_scanning_delegated_alert_dismissal", SecretScanningDelegatedAlertDismissal);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass>("secret_scanning_delegated_bypass", SecretScanningDelegatedBypass);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_delegated_bypass_options>("secret_scanning_delegated_bypass_options", SecretScanningDelegatedBypassOptions);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_generic_secrets>("secret_scanning_generic_secrets", SecretScanningGenericSecrets);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_non_provider_patterns>("secret_scanning_non_provider_patterns", SecretScanningNonProviderPatterns);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_push_protection>("secret_scanning_push_protection", SecretScanningPushProtection);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_secret_scanning_validity_checks>("secret_scanning_validity_checks", SecretScanningValidityChecks);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeSecurityConfiguration_target_type>("target_type", TargetType);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
