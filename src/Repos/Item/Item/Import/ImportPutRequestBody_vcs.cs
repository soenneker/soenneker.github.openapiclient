// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import
{
    /// <summary>The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ImportPutRequestBody_vcs
    {
        [EnumMember(Value = "subversion")]
        #pragma warning disable CS1591
        Subversion,
        #pragma warning restore CS1591
        [EnumMember(Value = "git")]
        #pragma warning disable CS1591
        Git,
        #pragma warning restore CS1591
        [EnumMember(Value = "mercurial")]
        #pragma warning disable CS1591
        Mercurial,
        #pragma warning restore CS1591
        [EnumMember(Value = "tfvc")]
        #pragma warning disable CS1591
        Tfvc,
        #pragma warning restore CS1591
    }
}
