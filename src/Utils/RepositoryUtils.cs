using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Soenneker.GitHub.OpenApiClient;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.User.Repos;
using Soenneker.GitHub.ClientUtil;

namespace Soenneker.GitHub.OpenApiClient.Utils
{
    /// <summary>
    /// Utility methods for working with GitHub repositories
    /// </summary>
    public static class RepositoryUtils
    {
        /// <summary>
        /// Creates a new repository for the authenticated user
        /// </summary>
        /// <param name="gitHubClientUtil">The GitHub API client utility</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="description">Optional description of the repository</param>
        /// <param name="isPrivate">Whether the repository should be private</param>
        /// <param name="autoInit">Whether to initialize the repository with a README</param>
        /// <param name="allowAutoMerge">Whether to allow auto-merge on pull requests</param>
        /// <param name="allowMergeCommit">Whether to allow merge commits</param>
        /// <param name="allowRebaseMerge">Whether to allow rebase merges</param>
        /// <param name="allowSquashMerge">Whether to allow squash merges</param>
        /// <param name="deleteBranchOnMerge">Whether to delete head branches when pull requests are merged</param>
        /// <param name="cancellationToken">Optional cancellation token</param>
        /// <returns>The created repository</returns>
        public static async Task<FullRepository> CreateRepositoryAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string name,
            string? description = null,
            bool isPrivate = false,
            bool autoInit = true,
            bool? allowAutoMerge = null,
            bool? allowMergeCommit = null,
            bool? allowRebaseMerge = null,
            bool? allowSquashMerge = null,
            bool? deleteBranchOnMerge = null,
            CancellationToken cancellationToken = default)
        {
            if (gitHubClientUtil == null)
                throw new ArgumentNullException(nameof(gitHubClientUtil));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Repository name cannot be empty", nameof(name));

            GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);

            var requestBody = new ReposPostRequestBody
            {
                Name = name,
                Description = description,
                Private = isPrivate,
                AutoInit = autoInit,
                AllowAutoMerge = allowAutoMerge,
                AllowMergeCommit = allowMergeCommit,
                AllowRebaseMerge = allowRebaseMerge,
                AllowSquashMerge = allowSquashMerge,
                DeleteBranchOnMerge = deleteBranchOnMerge
            };

            return await client.User.Repos.PostAsync(requestBody, null, cancellationToken);
        }

        /// <summary>
        /// Gets a repository by owner and name
        /// </summary>
        public static async Task<FullRepository?> GetByNameAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            string name,
            CancellationToken cancellationToken = default)
        {
            try
            {
                GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);
                return await client.Repos[owner][name].GetAsync(cancellationToken: cancellationToken);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all repositories for an owner
        /// </summary>
        public static async Task<IReadOnlyList<MinimalRepository>> GetAllForOwnerAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            DateTime? startAt = null,
            DateTime? endAt = null,
            CancellationToken cancellationToken = default)
        {
            GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);

            var allRepositories = new List<MinimalRepository>();
            var page = 1;
            IReadOnlyList<MinimalRepository> repositories;

            do
            {
                repositories = await client.Users[owner].Repos.GetAsync(
                    requestConfiguration => requestConfiguration.QueryParameters.Page = page,
                    cancellationToken);

                if (startAt == null && endAt == null)
                {
                    allRepositories.AddRange(repositories);
                }
                else if (startAt != null && endAt == null)
                {
                    allRepositories.AddRange(repositories.Where(r => r.CreatedAt >= startAt));
                }
                else if (startAt == null && endAt != null)
                {
                    allRepositories.AddRange(repositories.Where(r => r.CreatedAt <= endAt));
                }
                else
                {
                    allRepositories.AddRange(repositories.Where(r => r.CreatedAt >= startAt && r.CreatedAt <= endAt));
                }

                page++;
            } while (repositories.Count > 0 && !cancellationToken.IsCancellationRequested);

            return allRepositories;
        }

        /// <summary>
        /// Replaces topics for a repository
        /// </summary>
        public static async Task ReplaceTopicsAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            string name,
            List<string> topics,
            CancellationToken cancellationToken = default)
        {
            if (topics?.Any() == true)
            {
                GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);

                var requestBody = new Repos.Item.Item.Topics.TopicsPutRequestBody
                {
                    Names = topics
                };

                await client.Repos[owner][name].Topics.PutAsync(requestBody, cancellationToken: cancellationToken);
            }
        }

        /// <summary>
        /// Deletes a repository if it exists
        /// </summary>
        public static async Task DeleteIfExistsAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            string repository,
            CancellationToken cancellationToken = default)
        {
            string name = repository.ToLowerInvariant();

            if (!await DoesExistAsync(gitHubClientUtil, owner, name, cancellationToken))
                return;

            GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);
            await client.Repos[owner][name].DeleteAsync(cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Checks if a repository exists
        /// </summary>
        public static async Task<bool> DoesExistAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            string name,
            CancellationToken cancellationToken = default)
        {
            FullRepository? result = await GetByNameAsync(gitHubClientUtil, owner, name, cancellationToken);
            return result != null;
        }

        /// <summary>
        /// Toggles auto-merge for a repository
        /// </summary>
        public static async Task ToggleAutoMergeAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            string name,
            bool enable,
            CancellationToken cancellationToken = default)
        {
            GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);

            var requestBody = new RepoPatchRequestBody
            {
                AllowAutoMerge = enable
            };

            await client.Repos[owner][name].PatchAsync(requestBody, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Toggles discussions for a repository
        /// </summary>
        public static async Task ToggleDiscussionsAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            string name,
            bool enable,
            CancellationToken cancellationToken = default)
        {
            GitHubOpenApiClient client = await gitHubClientUtil.Get(cancellationToken);

            var requestBody = new RepoPatchRequestBody
            {
                HasIssues = true, // Discussions require issues to be enabled
                HasProjects = true, // Discussions require projects to be enabled
                HasWiki = true // Discussions require wiki to be enabled
            };

            await client.Repos[owner][name].PatchAsync(requestBody, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Toggles auto-merge for all repositories of an owner
        /// </summary>
        public static async Task ToggleAutoMergeOnAllReposAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            bool enable,
            DateTime? startAt = null,
            DateTime? endAt = null,
            CancellationToken cancellationToken = default)
        {
            IReadOnlyList<MinimalRepository> repositories = await GetAllForOwnerAsync(gitHubClientUtil, owner, startAt, endAt, cancellationToken);

            if (repositories?.Any() != true)
                return;

            foreach (MinimalRepository repo in repositories)
            {
                try
                {
                    await ToggleAutoMergeAsync(gitHubClientUtil, owner, repo.Name, enable, cancellationToken);
                }
                catch
                {
                    // Ignore errors for individual repositories
                }
            }
        }

        /// <summary>
        /// Toggles discussions for all repositories of an owner
        /// </summary>
        public static async Task ToggleDiscussionsOnAllReposAsync(
            IGitHubOpenApiClientUtil gitHubClientUtil,
            string owner,
            bool enable,
            DateTime? startAt = null,
            DateTime? endAt = null,
            CancellationToken cancellationToken = default)
        {
            IReadOnlyList<MinimalRepository> repositories = await GetAllForOwnerAsync(gitHubClientUtil, owner, startAt, endAt, cancellationToken);

            if (repositories?.Any() != true)
                return;

            foreach (MinimalRepository repo in repositories)
            {
                try
                {
                    await ToggleDiscussionsAsync(gitHubClientUtil, owner, repo.Name, enable, cancellationToken);
                }
                catch
                {
                    // Ignore errors for individual repositories
                }
            }
        }
    }
} 