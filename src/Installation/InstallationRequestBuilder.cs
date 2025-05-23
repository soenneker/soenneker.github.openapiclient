// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Installation.Repositories;
using Soenneker.GitHub.OpenApiClient.Installation.Token;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.GitHub.OpenApiClient.Installation
{
    /// <summary>
    /// Builds and executes requests for operations under \installation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InstallationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The repositories property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Installation.Repositories.RepositoriesRequestBuilder Repositories
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Installation.Repositories.RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The token property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Installation.Token.TokenRequestBuilder Token
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Installation.Token.TokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Installation.InstallationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstallationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/installation", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Installation.InstallationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstallationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/installation", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
