using Soenneker.GitHub.OpenApiClient.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Tags.Abstract;

public interface IGitHubRepositoriesTagsUtil
{
    ValueTask Create(string owner, string repo, string tagName, CancellationToken cancellationToken = default);
    ValueTask<bool> DoesTagExist(string owner, string repo, string tagName, CancellationToken cancellationToken = default);
    ValueTask Delete(string owner, string repo, string tagName, CancellationToken cancellationToken = default);
    ValueTask<IReadOnlyList<Tag>> GetAll(string owner, string repo, CancellationToken cancellationToken = default);
} 