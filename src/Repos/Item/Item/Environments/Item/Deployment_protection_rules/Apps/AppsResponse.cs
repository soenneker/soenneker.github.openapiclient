// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps
{
    [Obsolete("This class is obsolete. Use AppsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AppsResponse : global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps.AppsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps.AppsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps.AppsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps.AppsResponse();
        }
    }
}
#pragma warning restore CS0618
