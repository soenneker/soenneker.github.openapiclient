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
    public partial class CommunityProfile_files : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code_of_conduct property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeOfConductSimple? CodeOfConduct { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CodeOfConductSimple CodeOfConduct { get; set; }
#endif
        /// <summary>The code_of_conduct_file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile? CodeOfConductFile { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile CodeOfConductFile { get; set; }
#endif
        /// <summary>The contributing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile? Contributing { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile Contributing { get; set; }
#endif
        /// <summary>The issue_template property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile? IssueTemplate { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile IssueTemplate { get; set; }
#endif
        /// <summary>The license property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.LicenseSimple? License { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.LicenseSimple License { get; set; }
#endif
        /// <summary>The pull_request_template property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile? PullRequestTemplate { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile PullRequestTemplate { get; set; }
#endif
        /// <summary>The readme property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile? Readme { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile Readme { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CommunityProfile_files"/> and sets the default values.
        /// </summary>
        public CommunityProfile_files()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CommunityProfile_files"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CommunityProfile_files CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CommunityProfile_files();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "code_of_conduct", n => { CodeOfConduct = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeOfConductSimple>(global::Soenneker.GitHub.OpenApiClient.Models.CodeOfConductSimple.CreateFromDiscriminatorValue); } },
                { "code_of_conduct_file", n => { CodeOfConductFile = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>(global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile.CreateFromDiscriminatorValue); } },
                { "contributing", n => { Contributing = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>(global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile.CreateFromDiscriminatorValue); } },
                { "issue_template", n => { IssueTemplate = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>(global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile.CreateFromDiscriminatorValue); } },
                { "license", n => { License = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.LicenseSimple>(global::Soenneker.GitHub.OpenApiClient.Models.LicenseSimple.CreateFromDiscriminatorValue); } },
                { "pull_request_template", n => { PullRequestTemplate = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>(global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile.CreateFromDiscriminatorValue); } },
                { "readme", n => { Readme = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>(global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CodeOfConductSimple>("code_of_conduct", CodeOfConduct);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>("code_of_conduct_file", CodeOfConductFile);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>("contributing", Contributing);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>("issue_template", IssueTemplate);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.LicenseSimple>("license", License);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>("pull_request_template", PullRequestTemplate);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CommunityHealthFile>("readme", Readme);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
