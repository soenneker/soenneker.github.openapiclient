// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.Alerts;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.PushProtectionBypasses;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.ScanHistory;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\secret-scanning
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SecretScanningRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The alerts property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder Alerts
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pushProtectionBypasses property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder PushProtectionBypasses
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.PushProtectionBypasses.PushProtectionBypassesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scanHistory property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.ScanHistory.ScanHistoryRequestBuilder ScanHistory
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.ScanHistory.ScanHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.SecretScanningRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecretScanningRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/secret-scanning", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecretScanning.SecretScanningRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecretScanningRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/secret-scanning", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
