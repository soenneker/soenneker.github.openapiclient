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
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\teams\{team_slug}\members
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MembersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/members{?page*,per_page*,role*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/members{?page*,per_page*,role*}", rawUrl)
        {
        }
        /// <summary>
        /// Team members will include the members of child teams.To list members in a team, the team must be visible to the authenticated user.
        /// API method documentation <see href="https://docs.github.com/rest/teams/members#list-team-members" />
        /// </summary>
        /// <returns>A List&lt;global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>?> GetAsync(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder.MembersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>> GetAsync(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder.MembersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Team members will include the members of child teams.To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder.MembersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder.MembersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Team members will include the members of child teams.To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MembersRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Filters members returned by their role in the team.</summary>
            [Obsolete("This property is deprecated, use RoleAsGetRoleQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("role")]
            public string? Role { get; set; }
#nullable restore
#else
            [QueryParameter("role")]
            public string Role { get; set; }
#endif
            /// <summary>Filters members returned by their role in the team.</summary>
            [QueryParameter("role")]
            public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.GetRoleQueryParameterType? RoleAsGetRoleQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MembersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Teams.Item.Members.MembersRequestBuilder.MembersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
