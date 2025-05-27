using Microsoft.Extensions.Logging;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.ValueTask;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Commits.Item.CheckRuns;
using Soenneker.GitHub.OpenApiClient.Utils.Abstract;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Runs;

public class GitHubRepositoriesRunsUtil : IGitHubRepositoriesRunsUtil
{
    private readonly ILogger<GitHubRepositoriesRunsUtil> _logger;
    private readonly IGitHubOpenApiClientUtil _gitHubOpenApiClientUtil;

    public GitHubRepositoriesRunsUtil(ILogger<GitHubRepositoriesRunsUtil> logger, IGitHubOpenApiClientUtil gitHubOpenApiClientUtil)
    {
        _logger = logger;
        _gitHubOpenApiClientUtil = gitHubOpenApiClientUtil;
    }

    public ValueTask<bool> HasFailedRun(Repository repository, PullRequest pullRequest, CancellationToken cancellationToken = default)
    {
        return HasFailedRun(repository.Owner.Login, repository.Name, pullRequest, cancellationToken);
    }

    public async ValueTask<bool> HasFailedRun(string owner, string name, PullRequest pullRequest, CancellationToken cancellationToken = default)
    {
        var client = await _gitHubOpenApiClientUtil.Get(cancellationToken).NoSync();

        var response = await client.Repos[owner][name].Commits[pullRequest.Head.Sha].CheckRuns.GetAsync(cancellationToken: cancellationToken).NoSync();

        return response?.CheckRuns?.Any(cr => cr.Conclusion == CheckRun_conclusion.Failure) == true;
    }
} 