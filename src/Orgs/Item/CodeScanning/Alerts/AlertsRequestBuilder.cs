// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\code-scanning\alerts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AlertsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/code-scanning/alerts{?after*,before*,direction*,page*,per_page*,severity*,sort*,state*,tool_guid*,tool_name*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/code-scanning/alerts{?after*,before*,direction*,page*,per_page*,severity*,sort*,state*,tool_guid*,tool_name*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;The authenticated user must be an owner or security manager for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `security_events` or `repo`s cope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// API method documentation <see href="https://docs.github.com/rest/code-scanning/code-scanning#list-code-scanning-alerts-for-an-organization" />
        /// </summary>
        /// <returns>A List&lt;global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningOrganizationAlertItems&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.Alerts503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningOrganizationAlertItems>?> GetAsync(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningOrganizationAlertItems>> GetAsync(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "503", global::Soenneker.GitHub.OpenApiClient.Models.Alerts503Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningOrganizationAlertItems>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningOrganizationAlertItems.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;The authenticated user must be an owner or security manager for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `security_events` or `repo`s cope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;The authenticated user must be an owner or security manager for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `security_events` or `repo`s cope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AlertsRequestBuilderGetQueryParameters 
        {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results after this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results before this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [Obsolete("This property is deprecated, use DirectionAsGetDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("direction")]
            public string? Direction { get; set; }
#nullable restore
#else
            [QueryParameter("direction")]
            public string Direction { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>If specified, only code scanning alerts with this severity will be returned.</summary>
            [Obsolete("This property is deprecated, use SeverityAsCodeScanningAlertSeverity instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("severity")]
            public string? Severity { get; set; }
#nullable restore
#else
            [QueryParameter("severity")]
            public string Severity { get; set; }
#endif
            /// <summary>If specified, only code scanning alerts with this severity will be returned.</summary>
            [QueryParameter("severity")]
            public global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningAlertSeverity? SeverityAsCodeScanningAlertSeverity { get; set; }
            /// <summary>The property by which to sort the results.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>The property by which to sort the results.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
            /// <summary>If specified, only code scanning alerts with this state will be returned.</summary>
            [Obsolete("This property is deprecated, use StateAsCodeScanningAlertStateQuery instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("state")]
            public string? State { get; set; }
#nullable restore
#else
            [QueryParameter("state")]
            public string State { get; set; }
#endif
            /// <summary>If specified, only code scanning alerts with this state will be returned.</summary>
            [QueryParameter("state")]
            public global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningAlertStateQuery? StateAsCodeScanningAlertStateQuery { get; set; }
            /// <summary>The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tool_guid")]
            public string? ToolGuid { get; set; }
#nullable restore
#else
            [QueryParameter("tool_guid")]
            public string ToolGuid { get; set; }
#endif
            /// <summary>The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tool_name")]
            public string? ToolName { get; set; }
#nullable restore
#else
            [QueryParameter("tool_name")]
            public string ToolName { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AlertsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
