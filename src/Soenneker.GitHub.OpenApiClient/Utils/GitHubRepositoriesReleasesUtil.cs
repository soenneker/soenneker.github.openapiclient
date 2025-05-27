using Microsoft.Extensions.Logging;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.ValueTask;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Releases;
using Soenneker.GitHub.OpenApiClient.Utils.Abstract;
using Soenneker.GitHub.Repositories.Releases.Abstract;
using Soenneker.GitHub.Repositories.Tags.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Releases;

public sealed class GitHubRepositoriesReleasesUtil : IGitHubRepositoriesReleasesUtil
{
    private readonly IGitHubOpenApiClientUtil _gitHubOpenApiClientUtil;
    private readonly IGitHubRepositoriesTagsUtil _tagsUtil;
    private readonly ILogger<GitHubRepositoriesReleasesUtil> _logger;

    public GitHubRepositoriesReleasesUtil(ILogger<GitHubRepositoriesReleasesUtil> logger, IGitHubOpenApiClientUtil gitHubOpenApiClientUtil, IGitHubRepositoriesTagsUtil tagsUtil)
    {
        _logger = logger;
        _gitHubOpenApiClientUtil = gitHubOpenApiClientUtil;
        _tagsUtil = tagsUtil;
    }

    public async ValueTask Create(string owner, string repo, string tagName, string releaseName, string releaseBody, string filePath, bool isDraft = false,
        bool isPrerelease = false, CancellationToken cancellationToken = default)
    {
        try
        {
            bool tagExists = await _tagsUtil.DoesTagExist(owner, repo, tagName, cancellationToken);

            if (!tagExists)
            {
                await _tagsUtil.Create(owner, repo, tagName, cancellationToken);
                _logger.LogInformation("Tag '{TagName}' created successfully.", tagName);
            }
            else
            {
                _logger.LogInformation("Tag '{TagName}' already exists. Skipping tag creation.", tagName);
            }

            var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

            var releaseRequest = new ReleasesPostRequestBody
            {
                TagName = tagName,
                Name = releaseName,
                Body = releaseBody,
                Draft = isDraft,
                Prerelease = isPrerelease
            };

            var release = await client.Repos[owner][repo].Releases.PostAsync(releaseRequest, cancellationToken: cancellationToken);
            _logger.LogInformation("Release '{ReleaseName}' created successfully.", release.Name);

            await UploadAsset(release, filePath, cancellationToken);
            _logger.LogInformation("Executable '{FileName}' uploaded successfully.", Path.GetFileName(filePath));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unexpected error occurred: {Message}", ex.Message);
            throw;
        }
    }

    public async ValueTask<ReleaseAsset?> UploadAsset(Release release, string filePath, CancellationToken cancellationToken = default)
    {
        var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

        using var fileStream = File.OpenRead(filePath);
        var asset = await client.Repos[release.Author.Login][release.Name].Releases[release.Id.Value].Assets.PostAsync(fileStream, cancellationToken: cancellationToken);

        return asset;
    }

    public async ValueTask Delete(string owner, string repo, string tagName, bool deleteTag = true, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

            var release = await Get(owner, repo, tagName, cancellationToken);

            if (release == null)
                return;

            await client.Repos[owner][repo].Releases[release.Id.Value].DeleteAsync(cancellationToken: cancellationToken);
            _logger.LogInformation("Release with tag '{TagName}' deleted successfully.", tagName);

            if (deleteTag)
            {
                bool tagExists = await _tagsUtil.DoesTagExist(owner, repo, tagName, cancellationToken);

                if (tagExists)
                {
                    await _tagsUtil.Delete(owner, repo, tagName, cancellationToken);
                    _logger.LogInformation("Tag '{TagName}' deleted successfully.", tagName);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while deleting the release: {Message}", ex.Message);
            throw;
        }
    }

    public async ValueTask<Release?> Get(string owner, string repo, string tagName, CancellationToken cancellationToken = default)
    {
        var releases = await GetAll(owner, repo, cancellationToken);

        var release = releases.FirstOrDefault(r => r.TagName == tagName);

        if (release == null)
        {
            _logger.LogWarning("No release found for tag '{TagName}' in repository '{Repo}'.", tagName, repo);
            return null;
        }

        _logger.LogInformation("Successfully retrieved release '{ReleaseName}' with tag '{TagName}'.", release.Name, tagName);
        return release;
    }

    public async ValueTask<IReadOnlyList<Release>> GetAll(string owner, string repo, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

            var releases = await client.Repos[owner][repo].Releases.GetAsync(cancellationToken: cancellationToken);

            _logger.LogInformation("Successfully retrieved {Count} releases for repository '{Repo}'.", releases.Count, repo);

            return releases;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving releases for repository '{Repo}': {Message}", repo, ex.Message);
            throw;
        }
    }

    private static string GetMimeType(string filePath)
    {
        string extension = Path.GetExtension(filePath).ToLowerInvariant();
        return extension switch
        {
            ".exe" => "application/vnd.microsoft.portable-executable",
            ".zip" => "application/zip",
            ".tar" => "application/x-tar",
            ".gz" => "application/gzip",
            _ => "application/octet-stream",
        };
    }
} 