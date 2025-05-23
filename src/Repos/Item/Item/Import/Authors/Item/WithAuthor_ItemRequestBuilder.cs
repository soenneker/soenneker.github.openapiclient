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
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\import\authors\{author_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithAuthor_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAuthor_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/import/authors/{author_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAuthor_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/import/authors/{author_id}", rawUrl)
        {
        }
        /// <summary>
        /// Update an author&apos;s identity for the import. Your application can continue updating authors any time before you pushnew commits to the repository.&gt; [!WARNING]&gt; **Endpoint closing down notice:** Due to very low levels of usage and available alternatives, this endpoint is closing down and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// API method documentation <see href="https://docs.github.com/rest/migrations/source-imports#map-a-commit-author" />
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.PorterAuthor"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 503 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.GitHub.OpenApiClient.Models.PorterAuthor?> PatchAsync(global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.GitHub.OpenApiClient.Models.PorterAuthor> PatchAsync(global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.GitHub.OpenApiClient.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.GitHub.OpenApiClient.Models.PorterAuthor>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Models.PorterAuthor.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update an author&apos;s identity for the import. Your application can continue updating authors any time before you pushnew commits to the repository.&gt; [!WARNING]&gt; **Endpoint closing down notice:** Due to very low levels of usage and available alternatives, this endpoint is closing down and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Import.Authors.Item.WithAuthor_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithAuthor_ItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
