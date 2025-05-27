using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.OpenApiClient
{
    public interface IGitHubOpenApiClientUtil
    {
        Task<GitHubOpenApiClient> Get(CancellationToken cancellationToken = default);
    }
} 