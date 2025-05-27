using System;
using System.Threading;
using System.Threading.Tasks;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.User.Repos;
using Soenneker.GitHub.OpenApiClient.Utils.Abstract;

namespace Soenneker.GitHub.OpenApiClient.Utils
{
    public class GitHubRepositoriesUtil
    {
        private readonly IGitHubOpenApiClientUtil _gitHubOpenApiClientUtil;

        public GitHubRepositoriesUtil(IGitHubOpenApiClientUtil gitHubOpenApiClientUtil)
        {
            _gitHubOpenApiClientUtil = gitHubOpenApiClientUtil;
        }

        public async ValueTask<FullRepository> Create(string owner, string name, string? description = null, bool isPrivate = false, bool autoInit = true,
            bool? allowAutoMerge = null, bool? allowMergeCommit = null, bool? allowRebaseMerge = null, bool? allowSquashMerge = null, bool? hasDiscussions = null,
            bool? deleteBranchOnMerge = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Repository name cannot be empty", nameof(name));

            if (string.IsNullOrWhiteSpace(owner))
                throw new ArgumentException("Owner cannot be empty", nameof(owner));

            var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

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
                HasDiscussions = hasDiscussions,
                DeleteBranchOnMerge = deleteBranchOnMerge
            };

            return await client.User.Repos.PostAsync(requestBody, cancellationToken: cancellationToken);
        }
    }
} 