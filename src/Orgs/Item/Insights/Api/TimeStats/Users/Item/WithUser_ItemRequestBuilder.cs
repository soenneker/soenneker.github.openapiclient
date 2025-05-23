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
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\insights\api\time-stats\users\{user_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithUser_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUser_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/insights/api/time-stats/users/{user_id}?min_timestamp={min_timestamp}&timestamp_increment={timestamp_increment}{&max_timestamp*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUser_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/insights/api/time-stats/users/{user_id}?min_timestamp={min_timestamp}&timestamp_increment={timestamp_increment}{&max_timestamp*}", rawUrl)
        {
        }
        /// <summary>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.
        /// API method documentation <see href="https://docs.github.com/rest/orgs/api-insights#get-time-stats-by-user" />
        /// </summary>
        /// <returns>A List&lt;global::Soenneker.GitHub.OpenApiClient.Models.ApiInsightsTimeStats&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Soenneker.GitHub.OpenApiClient.Models.ApiInsightsTimeStats>?> GetAsync(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder.WithUser_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Soenneker.GitHub.OpenApiClient.Models.ApiInsightsTimeStats>> GetAsync(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder.WithUser_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Soenneker.GitHub.OpenApiClient.Models.ApiInsightsTimeStats>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Models.ApiInsightsTimeStats.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder.WithUser_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder.WithUser_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUser_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum timestamp to query for stats. Defaults to the time 30 days ago. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("max_timestamp")]
            public string? MaxTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("max_timestamp")]
            public string MaxTimestamp { get; set; }
#endif
            /// <summary>The minimum timestamp to query for stats. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("min_timestamp")]
            public string? MinTimestamp { get; set; }
#nullable restore
#else
            [QueryParameter("min_timestamp")]
            public string MinTimestamp { get; set; }
#endif
            /// <summary>The increment of time used to breakdown the query results (5m, 10m, 1h, etc.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("timestamp_increment")]
            public string? TimestampIncrement { get; set; }
#nullable restore
#else
            [QueryParameter("timestamp_increment")]
            public string TimestampIncrement { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUser_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Insights.Api.TimeStats.Users.Item.WithUser_ItemRequestBuilder.WithUser_ItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
