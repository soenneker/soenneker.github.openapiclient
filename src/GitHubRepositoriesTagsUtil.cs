using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Git.Tags;

namespace Soenneker.GitHub.OpenApiClient
{
    public class GitHubRepositoriesTagsUtil
    {
        private readonly ILogger<GitHubRepositoriesTagsUtil> _logger;
        private readonly IGitHubOpenApiClientUtil _gitHubClientUtil;

        public GitHubRepositoriesTagsUtil(ILogger<GitHubRepositoriesTagsUtil> logger, IGitHubOpenApiClientUtil gitHubClientUtil)
        {
            _logger = logger;
            _gitHubClientUtil = gitHubClientUtil;
        }

        public async ValueTask<bool> DoesTagExist(string owner, string repo, string tagName, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Checking if tag {TagName} exists in {Owner}/{Repo}...", tagName, owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            var tags = await client.Repos[owner][repo].Tags.GetAsync(
                requestConfiguration => 
                {
                    requestConfiguration.QueryParameters.PerPage = 100;
                }, 
                cancellationToken);

            if (tags == null)
                return false;

            foreach (var tag in tags)
            {
                if (string.Equals(tag.Name, tagName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        public async ValueTask Create(string owner, string repo, string tagName, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Creating tag {TagName} in {Owner}/{Repo}...", tagName, owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            // Get the latest commit SHA (HEAD)
            var repoInfo = await client.Repos[owner][repo].GetAsync(cancellationToken: cancellationToken);
            var branch = await client.Repos[owner][repo].Branches[repoInfo.DefaultBranch].GetAsync(cancellationToken: cancellationToken);
            string latestCommitSha = branch.Commit.Sha;

            // Create a Git tag
            var tagBody = new TagsPostRequestBody
            {
                Tag = tagName,
                Message = $"Tag {tagName}",
                Object = latestCommitSha,
                Type = TagsPostRequestBody_type.Commit
            };

            await client.Repos[owner][repo].Git.Tags.PostAsync(tagBody, cancellationToken: cancellationToken);

            // Create a reference to the tag
            var refBody = new Repos.Item.Item.Git.Refs.RefsPostRequestBody
            {
                Ref = $"refs/tags/{tagName}",
                Sha = latestCommitSha
            };

            await client.Repos[owner][repo].Git.Refs.PostAsync(refBody, cancellationToken: cancellationToken);
        }

        public async ValueTask<IReadOnlyList<Tag>> GetAll(string owner, string repo, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting all tags for {Owner}/{Repo}...", owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            var result = new List<Tag>();
            var page = 1;

            while (true)
            {
                var tags = await client.Repos[owner][repo].Tags.GetAsync(
                    requestConfiguration => 
                    {
                        requestConfiguration.QueryParameters.Page = page;
                        requestConfiguration.QueryParameters.PerPage = 100;
                    }, 
                    cancellationToken);

                if (tags?.Count == 0)
                    break;

                if (tags != null)
                {
                    result.AddRange(tags);
                }

                if (tags?.Count < 100)
                    break;

                page++;
            }

            return result;
        }

        public async ValueTask<GitTag> GetTagDetails(string owner, string repo, string tagName, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting details for tag {TagName} in {Owner}/{Repo}...", tagName, owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            var tags = await GetAll(owner, repo, cancellationToken);

            foreach (var tag in tags)
            {
                if (string.Equals(tag.Name, tagName, StringComparison.OrdinalIgnoreCase))
                {
                    // Get the tag reference (use .Git.Ref not .Git.Refs)
                    var reference = await client.Repos[owner][repo].Git.Ref["tags/" + tagName].GetAsync(cancellationToken: cancellationToken);
                    var gitTag = await client.Repos[owner][repo].Git.Tags[reference.Object?.Sha].GetAsync(cancellationToken: cancellationToken);
                    return gitTag;
                }
            }

            throw new ArgumentException($"Tag '{tagName}' does not exist in repository '{owner}/{repo}'.");
        }

        public async ValueTask Delete(string owner, string repo, string tagName, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Deleting tag {TagName} from {Owner}/{Repo}...", tagName, owner, repo);

            // First, ensure the tag exists
            bool exists = await DoesTagExist(owner, repo, tagName, cancellationToken);

            if (!exists)
                throw new ArgumentException($"Tag '{tagName}' does not exist in repository '{owner}/{repo}'.");

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            // Delete the tag reference
            await client.Repos[owner][repo].Git.Refs["tags/" + tagName].DeleteAsync(cancellationToken: cancellationToken);
        }

        public async ValueTask<GitCommit> GetTagCommit(string owner, string repo, string tagName, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting commit for tag {TagName} in {Owner}/{Repo}...", tagName, owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            // Get the tag reference (use .Git.Ref not .Git.Refs)
            var reference = await client.Repos[owner][repo].Git.Ref["tags/" + tagName].GetAsync(cancellationToken: cancellationToken);

            // Get the tag object
            var tag = await client.Repos[owner][repo].Git.Tags[reference.Object?.Sha].GetAsync(cancellationToken: cancellationToken);

            // Get the commit
            return await client.Repos[owner][repo].Git.Commits[tag.Object.Sha].GetAsync(cancellationToken: cancellationToken);
        }

        public async ValueTask<CommitComparison> Compare(string owner, string repo, string baseTag, string headTag, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Comparing tags {BaseTag} and {HeadTag} in {Owner}/{Repo}...", baseTag, headTag, owner, repo);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            return await client.Repos[owner][repo].Compare[baseTag + "..." + headTag].GetAsync(cancellationToken: cancellationToken);
        }
    }
} 