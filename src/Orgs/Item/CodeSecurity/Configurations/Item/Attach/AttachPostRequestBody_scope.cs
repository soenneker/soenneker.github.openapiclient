// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeSecurity.Configurations.Item.Attach
{
    /// <summary>The type of repositories to attach the configuration to. `selected` means the configuration will be attached to only the repositories specified by `selected_repository_ids`</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AttachPostRequestBody_scope
    {
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
        [EnumMember(Value = "all_without_configurations")]
        #pragma warning disable CS1591
        All_without_configurations,
        #pragma warning restore CS1591
        [EnumMember(Value = "public")]
        #pragma warning disable CS1591
        Public,
        #pragma warning restore CS1591
        [EnumMember(Value = "private_or_internal")]
        #pragma warning disable CS1591
        Private_or_internal,
        #pragma warning restore CS1591
        [EnumMember(Value = "selected")]
        #pragma warning disable CS1591
        Selected,
        #pragma warning restore CS1591
    }
}
