using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Contents.Item;
using Soenneker.GitHub.OpenApiClient.Utils.Abstract;
using Soenneker.GitHub.Repositories.Readmes.Abstract;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.GitHub.Repositories.Readmes;

public sealed class GitHubRepositoriesReadmesUtil : IGitHubRepositoriesReadmesUtil
{
    private readonly ILogger<GitHubRepositoriesReadmesUtil> _logger;
    private readonly Soenneker.GitHub.OpenApiClient.Utils.Abstract.IGitHubOpenApiClientUtil _gitHubOpenApiClientUtil;

    public GitHubRepositoriesReadmesUtil(ILogger<GitHubRepositoriesReadmesUtil> logger, Soenneker.GitHub.OpenApiClient.Utils.Abstract.IGitHubOpenApiClientUtil gitHubOpenApiClientUtil)
    {
        _logger = logger;
        _gitHubOpenApiClientUtil = gitHubOpenApiClientUtil;
    }

    public async ValueTask Create(string owner, string name, string commitMessage, string content, string branch = "main", CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Creating README.md for GitHub repository ({owner}/{name})...", owner, name);

        var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

        var requestBody = new WithPathPutRequestBody
        {
            Message = commitMessage,
            Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(content)),
            Branch = branch
        };

        await client.Repos[owner][name].Contents["README.md"].PutAsync(requestBody, cancellationToken: cancellationToken);
    }

    public async ValueTask Update(string owner, string name, string commitMessage, string content, string branch = "main", CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Updating README.md for GitHub repository ({owner}/{name})...", owner, name);

        var client = await _gitHubOpenApiClientUtil.Get(cancellationToken);

        // Get the current file to get its SHA
        var response = await client.Repos[owner][name].Contents["README.md"].GetAsWithPathGetResponseAsync(cancellationToken: cancellationToken);
        if (response?.ContentFile == null)
        {
            throw new Exception($"README.md not found in repository {owner}/{name}");
        }

        var requestBody = new WithPathPutRequestBody
        {
            Message = commitMessage,
            Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(content)),
            Branch = branch,
            Sha = response.ContentFile.Sha
        };

        await client.Repos[owner][name].Contents["README.md"].PutAsync(requestBody, cancellationToken: cancellationToken);
    }

    public async ValueTask Upsert(string owner, string name, string commitMessage, string content, string branch = "main", CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Upserting README.md for GitHub repository ({owner}/{name})...", owner, name);

        try
        {
            await Update(owner, name, commitMessage, content, branch, cancellationToken);
        }
        catch (Exception ex) when (ex.Message.Contains("not found"))
        {
            _logger.LogInformation("Existing README.md was not found, creating new one...");
            await Create(owner, name, commitMessage, content, branch, cancellationToken);
        }
    }
} 