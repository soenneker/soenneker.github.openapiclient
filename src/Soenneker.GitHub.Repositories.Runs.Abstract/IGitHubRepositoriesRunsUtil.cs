using Soenneker.GitHub.OpenApiClient.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Runs.Abstract;

public interface IGitHubRepositoriesRunsUtil
{
    ValueTask<bool> HasFailedRun(Repository repository, PullRequest pullRequest, CancellationToken cancellationToken = default);
    ValueTask<bool> HasFailedRun(string owner, string name, PullRequest pullRequest, CancellationToken cancellationToken = default);
} 