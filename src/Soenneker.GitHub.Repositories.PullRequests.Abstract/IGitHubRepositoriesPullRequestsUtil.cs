using Soenneker.GitHub.OpenApiClient.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.PullRequests.Abstract;

public interface IGitHubRepositoriesPullRequestsUtil
{
    ValueTask<IReadOnlyList<PullRequest>> GetAll(Repository repository, string? username = null, DateTime? startAt = null, DateTime? endAt = null,
        bool log = true, CancellationToken cancellationToken = default);

    ValueTask<IReadOnlyList<PullRequest>> GetAll(string owner, string name, string? username = null, DateTime? startAt = null,
        DateTime? endAt = null, bool log = true, CancellationToken cancellationToken = default);

    ValueTask<List<PullRequest>> GetAllForOwner(string owner, string? username = null, DateTime? startAt = null, DateTime? endAt = null,
        bool log = false, CancellationToken cancellationToken = default);

    ValueTask<List<PullRequest>> GetAllNonApproved(string owner, string name, string? username = null, DateTime? startAt = null,
        DateTime? endAt = null, bool log = true, CancellationToken cancellationToken = default);

    ValueTask<List<PullRequest>> GetAllNonApprovedForOwner(string owner, string? username = null, DateTime? startAt = null, DateTime? endAt = null,
        bool log = true, CancellationToken cancellationToken = default);

    ValueTask<bool> IsApproved(string owner, string repo, int pullRequestNumber, CancellationToken cancellationToken = default);

    ValueTask ApproveAll(Repository repository, string message, string? username = null, DateTime? startAt = null, DateTime? endAt = null,
        int delayMs = 0, CancellationToken cancellationToken = default);

    ValueTask ApproveAll(string owner, string name, string message, DateTime? startAt = null, DateTime? endAt = null, string? username = null,
        int delayMs = 0, CancellationToken cancellationToken = default);

    ValueTask Approve(Repository repository, PullRequest pullRequest, string message, CancellationToken cancellationToken = default);

    ValueTask Approve(string owner, string name, PullRequest pullRequest, string message, CancellationToken cancellationToken = default);

    ValueTask<IReadOnlyList<Repository>> FilterRepositoriesWithOpenPullRequests(IReadOnlyList<Repository> repositories, DateTime? startAt = null,
        DateTime? endAt = null, bool log = true, CancellationToken cancellationToken = default);

    ValueTask<IReadOnlyList<Repository>> FilterRepositoriesWithFailedBuilds(IReadOnlyList<Repository> repositories, DateTime? startAt = null,
        DateTime? endAt = null, bool log = true, CancellationToken cancellationToken = default);

    ValueTask<IReadOnlyList<Repository>> GetAllRepositoriesWithFailedBuildsOnOpenPullRequests(string owner, DateTime? startAt = null,
        DateTime? endAt = null, bool log = true, CancellationToken cancellationToken = default);

    ValueTask<IReadOnlyList<Repository>> GetAllRepositoriesWithOpenPullRequests(string owner, DateTime? startAt = null, DateTime? endAt = null,
        bool log = true, CancellationToken cancellationToken = default);
} 