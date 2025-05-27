using Soenneker.GitHub.OpenApiClient.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Releases.Abstract;

public interface IGitHubRepositoriesReleasesUtil
{
    ValueTask Create(string owner, string repo, string tagName, string releaseName, string releaseBody, string filePath, bool isDraft = false,
        bool isPrerelease = false, CancellationToken cancellationToken = default);

    ValueTask<ReleaseAsset?> UploadAsset(Release release, string filePath, CancellationToken cancellationToken = default);

    ValueTask Delete(string owner, string repo, string tagName, bool deleteTag = true, CancellationToken cancellationToken = default);

    ValueTask<Release?> Get(string owner, string repo, string tagName, CancellationToken cancellationToken = default);

    ValueTask<IReadOnlyList<Release>> GetAll(string owner, string repo, CancellationToken cancellationToken = default);
} 