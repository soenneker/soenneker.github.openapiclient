using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Issues;
using Soenneker.GitHub.OpenApiClient.Utils;

namespace Soenneker.GitHub.OpenApiClient.Utils;

public class GitHubRepositoriesIssuesUtil
{
    private readonly ILogger<GitHubRepositoriesIssuesUtil> _logger;
    private readonly IGitHubOpenApiClientUtil _gitHubClientUtil;

    public GitHubRepositoriesIssuesUtil(ILogger<GitHubRepositoriesIssuesUtil> logger, IGitHubOpenApiClientUtil gitHubClientUtil)
    {
        _logger = logger;
        _gitHubClientUtil = gitHubClientUtil;
    }

    public async ValueTask<List<Issue>> GetAll(string owner, string name, bool includeDependencyIssues = true, CancellationToken cancellationToken = default)
    {
        var client = await _gitHubClientUtil.Get(cancellationToken);
        var allIssues = new List<Issue>();
        var page = 1;
        List<Issue> issues;

        do
        {
            var response = await client.Repos[owner][name].Issues.GetAsync(config => 
            {
                config.QueryParameters.State = "open";
                config.QueryParameters.PerPage = 100;
                config.QueryParameters.Page = page;
            }, cancellationToken);

            issues = response?.ToList() ?? new List<Issue>();

            foreach (var issue in issues)
            {
                if (includeDependencyIssues)
                {
                    allIssues.Add(issue);
                }
                else
                {
                    if (!issue.Title.Contains("Update dependency"))
                        allIssues.Add(issue);
                }
            }

            page++;
        } while (issues.Count > 0 && !cancellationToken.IsCancellationRequested);

        return allIssues;
    }

    public async ValueTask<List<Issue>?> GetAllForOwner(string owner, bool includeDependencyIssues = true, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default)
    {
        var client = await _gitHubClientUtil.Get(cancellationToken);
        var response = await client.Users[owner].Repos.GetAsync(cancellationToken: cancellationToken);
        var repositories = response?.ToList() ?? new List<MinimalRepository>();

        if (!repositories.Any())
            return null;

        List<Issue>? result = null;

        foreach (var repo in repositories)
        {
            var issues = await GetAll(owner, repo.Name, includeDependencyIssues, cancellationToken);

            if (issues.Any())
            {
                result ??= [];
                result.AddRange(issues);
            }
        }

        return result;
    }

    public async ValueTask LogAll(string owner, string name, bool includeDependencyIssues = true, CancellationToken cancellationToken = default)
    {
        var issues = await GetAll(owner, name, includeDependencyIssues, cancellationToken);

        if (!issues.Any())
            return;

        foreach (var issue in issues)
        {
            _logger.LogInformation("{repo}: title: {title}, updated at: {opened}", name, issue.Title, issue.UpdatedAt);
        }
    }

    public async ValueTask LogAllForOwner(string owner, bool includeDependencyIssues = true, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default)
    {
        var client = await _gitHubClientUtil.Get(cancellationToken);
        var response = await client.Users[owner].Repos.GetAsync(cancellationToken: cancellationToken);
        var repositories = response?.ToList() ?? new List<MinimalRepository>();

        if (!repositories.Any())
            return;

        foreach (var repo in repositories)
        {
            var issues = await GetAll(owner, repo.Name, includeDependencyIssues, cancellationToken);

            if (!issues.Any())
                continue;

            foreach (var issue in issues)
            {
                _logger.LogInformation("{repo}: title: {title}, updated at: {opened}", repo.Name, issue.Title, issue.UpdatedAt);
            }
        }
    }
} 