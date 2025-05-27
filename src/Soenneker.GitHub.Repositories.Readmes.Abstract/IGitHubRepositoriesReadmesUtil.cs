using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Readmes.Abstract;

public interface IGitHubRepositoriesReadmesUtil
{
    ValueTask Create(string owner, string name, string commitMessage, string content, string branch = "main", CancellationToken cancellationToken = default);
    ValueTask Update(string owner, string name, string commitMessage, string content, string branch = "main", CancellationToken cancellationToken = default);
    ValueTask Upsert(string owner, string name, string commitMessage, string content, string branch = "main", CancellationToken cancellationToken = default);
} 