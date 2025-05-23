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
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\security-advisories\{ghsa_id}\cve
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CveRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CveRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/security-advisories/{ghsa_id}/cve", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CveRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/security-advisories/{ghsa_id}/cve", rawUrl)
        {
        }
        /// <summary>
        /// If you want a CVE identification number for the security vulnerability in your project, and don&apos;t already have one, you can request a CVE identification number from GitHub. For more information see &quot;[Requesting a CVE identification number](https://docs.github.com/code-security/security-advisories/repository-security-advisories/publishing-a-repository-security-advisory#requesting-a-cve-identification-number-optional).&quot;You may request a CVE for public repositories, but cannot do so for private repositories.In order to request a CVE for a repository security advisory, the authenticated user must be a security manager or administrator of that repository.OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/security-advisories/repository-advisories#request-a-cve-for-a-repository-security-advisory" />
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CvePostResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CvePostResponse?> PostAsCvePostResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CvePostResponse> PostAsCvePostResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.GitHub.OpenApiClient.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CvePostResponse>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CvePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// If you want a CVE identification number for the security vulnerability in your project, and don&apos;t already have one, you can request a CVE identification number from GitHub. For more information see &quot;[Requesting a CVE identification number](https://docs.github.com/code-security/security-advisories/repository-security-advisories/publishing-a-repository-security-advisory#requesting-a-cve-identification-number-optional).&quot;You may request a CVE for public repositories, but cannot do so for private repositories.In order to request a CVE for a repository security advisory, the authenticated user must be a security manager or administrator of that repository.OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/security-advisories/repository-advisories#request-a-cve-for-a-repository-security-advisory" />
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.GitHub.OpenApiClient.Models.ValidationError">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsCvePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveResponse?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveResponse> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.GitHub.OpenApiClient.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.GitHub.OpenApiClient.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveResponse>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// If you want a CVE identification number for the security vulnerability in your project, and don&apos;t already have one, you can request a CVE identification number from GitHub. For more information see &quot;[Requesting a CVE identification number](https://docs.github.com/code-security/security-advisories/repository-security-advisories/publishing-a-repository-security-advisory#requesting-a-cve-identification-number-optional).&quot;You may request a CVE for public repositories, but cannot do so for private repositories.In order to request a CVE for a repository security advisory, the authenticated user must be a security manager or administrator of that repository.OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.SecurityAdvisories.Item.Cve.CveRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CveRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
