// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    /// <summary>The new status of the CodeQL variant analysis repository task.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CodeScanningVariantAnalysisStatus
    {
        [EnumMember(Value = "pending")]
        #pragma warning disable CS1591
        Pending,
        #pragma warning restore CS1591
        [EnumMember(Value = "in_progress")]
        #pragma warning disable CS1591
        In_progress,
        #pragma warning restore CS1591
        [EnumMember(Value = "succeeded")]
        #pragma warning disable CS1591
        Succeeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "failed")]
        #pragma warning disable CS1591
        Failed,
        #pragma warning restore CS1591
        [EnumMember(Value = "canceled")]
        #pragma warning disable CS1591
        Canceled,
        #pragma warning restore CS1591
        [EnumMember(Value = "timed_out")]
        #pragma warning disable CS1591
        Timed_out,
        #pragma warning restore CS1591
    }
}
