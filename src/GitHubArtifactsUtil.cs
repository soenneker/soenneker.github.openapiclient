using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Artifacts;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Artifacts.Item;
using Soenneker.GitHub.OpenApiClient.Utils;

namespace Soenneker.GitHub.OpenApiClient
{
    public class GitHubArtifactsUtil
    {
        private readonly ILogger<GitHubArtifactsUtil> _logger;
        private readonly IGitHubOpenApiClientUtil _gitHubClientUtil;
        private readonly int _maximumPerPage;

        public GitHubArtifactsUtil(
            ILogger<GitHubArtifactsUtil> logger,
            IGitHubOpenApiClientUtil gitHubClientUtil,
            int maximumPerPage = 100)
        {
            _logger = logger;
            _gitHubClientUtil = gitHubClientUtil;
            _maximumPerPage = maximumPerPage;
        }

        public async ValueTask<List<Artifact>> GetAllForOwner(string owner, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting all artifacts for owner ({owner})...", owner);

            IReadOnlyList<MinimalRepository> allRepos = await RepositoryUtils.GetAllForOwnerAsync(_gitHubClientUtil, owner, startAt, endAt, cancellationToken);

            var result = new List<Artifact>();

            foreach (MinimalRepository repo in allRepos)
            {
                List<Artifact> artifacts = await GetAllForRepo(owner, repo.Name, cancellationToken);
                result.AddRange(artifacts);
            }

            return result;
        }

        public async ValueTask<List<Artifact>> GetAllForRepo(string owner, string repo, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting all artifacts for repo ({owner}/{repo})...", owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            var result = new List<Artifact>();
            var page = 1;

            while (true)
            {
                ArtifactsGetResponse? artifactsResponse = await client.Repos[owner][repo].Actions.Artifacts.GetAsArtifactsGetResponseAsync(
                    requestConfiguration => 
                    {
                        requestConfiguration.QueryParameters.Page = page;
                        requestConfiguration.QueryParameters.PerPage = _maximumPerPage;
                    }, 
                    cancellationToken);

                if (artifactsResponse?.TotalCount == 0)
                    break;

                _logger.LogDebug("{count} artifacts found", artifactsResponse?.TotalCount);

                if (artifactsResponse?.Artifacts != null)
                {
                    result.AddRange(artifactsResponse.Artifacts);
                }

                if (artifactsResponse?.Artifacts?.Count < _maximumPerPage)
                    break;

                page++;
            }

            return result;
        }

        public async ValueTask<List<Artifact>> GetAllOlderThan(string owner, string repo, int olderThanDays = 3, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting all artifacts older than {days} days...", olderThanDays);

            List<Artifact> allArtifacts = await GetAllForRepo(owner, repo, cancellationToken);

            var results = new List<Artifact>();

            foreach (Artifact? artifact in allArtifacts)
            {
                if (artifact?.CreatedAt == null)
                    continue;

                int ageDays = (int)(DateTime.UtcNow - artifact.CreatedAt.Value.DateTime).TotalDays;

                if (ageDays > olderThanDays)
                {
                    results.Add(artifact);
                }
            }

            return results;
        }

        public async ValueTask DeleteOldArtifacts(string owner, string repo, int keepWithinDays = 3, CancellationToken cancellationToken = default)
        {
            List<Artifact> artifacts = await GetAllOlderThan(owner, repo, keepWithinDays, cancellationToken);

            await DeleteArtifacts(owner, repo, artifacts, cancellationToken);
        }

        public async ValueTask DeleteArtifacts(string owner, string repositoryName, List<Artifact> artifacts, CancellationToken cancellationToken = default)
        {
            _logger.LogWarning("Deleting {count} artifacts...", artifacts.Count);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            foreach (Artifact artifact in artifacts)
            {
                if (artifact.Id == null)
                    continue;

                int ageDays = (int)(DateTime.UtcNow - artifact.CreatedAt!.Value.DateTime).TotalDays;

                _logger.LogInformation("Deleting artifact {artifactName} ({artifactId}) that's {age} days old...", 
                    artifact.Name, artifact.Id, ageDays);

                await client.Repos[owner][repositoryName].Actions.Artifacts[artifact.Id.Value].DeleteAsync(cancellationToken: cancellationToken);

                await Task.Delay(500, cancellationToken);
            }
        }
    }
} 