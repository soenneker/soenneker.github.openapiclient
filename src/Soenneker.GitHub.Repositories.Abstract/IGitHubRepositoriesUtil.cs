using Soenneker.GitHub.OpenApiClient.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Abstract;

public interface IGitHubRepositoriesUtil
{
    ValueTask<IReadOnlyList<MinimalRepository>> GetAllForOwner(string owner, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default);
    ValueTask<FullRepository?> GetByName(string owner, string name, CancellationToken cancellationToken = default);
    ValueTask<bool> DoesExist(string owner, string name, CancellationToken cancellationToken = default);
    ValueTask DeleteIfExists(string owner, string repository, CancellationToken cancellationToken = default);
    ValueTask ToggleAutoMerge(string owner, string name, bool enable, CancellationToken cancellationToken = default);
    ValueTask ToggleDiscussions(string owner, string name, bool enable, CancellationToken cancellationToken = default);
    ValueTask ToggleAutoMergeOnAllRepos(string owner, bool enable, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default);
    ValueTask ReplaceTopics(string owner, string name, List<string> topics, CancellationToken cancellationToken = default);
} 