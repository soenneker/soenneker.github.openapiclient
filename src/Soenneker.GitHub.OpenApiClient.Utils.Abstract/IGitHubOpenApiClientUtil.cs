using Soenneker.GitHub.OpenApiClient;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.OpenApiClient.Utils.Abstract;

public interface IGitHubOpenApiClientUtil
{
    ValueTask<GitHubOpenApiClient> Get(CancellationToken cancellationToken = default);
} 