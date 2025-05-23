// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    /// <summary>When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum RepositoryRulesetBypassActor_bypass_mode
    {
        [EnumMember(Value = "always")]
        #pragma warning disable CS1591
        Always,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_request")]
        #pragma warning disable CS1591
        Pull_request,
        #pragma warning restore CS1591
    }
}
