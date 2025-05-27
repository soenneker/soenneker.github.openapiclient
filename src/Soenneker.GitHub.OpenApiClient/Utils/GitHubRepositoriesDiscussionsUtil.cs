using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Utils;

namespace Soenneker.GitHub.OpenApiClient.Utils;

public class GitHubRepositoriesDiscussionsUtil
{
    private readonly ILogger<GitHubRepositoriesDiscussionsUtil> _logger;
    private readonly IGitHubOpenApiClientUtil _gitHubClientUtil;
    private readonly HttpClient _httpClient;

    public GitHubRepositoriesDiscussionsUtil(ILogger<GitHubRepositoriesDiscussionsUtil> logger, IGitHubOpenApiClientUtil gitHubClientUtil, HttpClient httpClient)
    {
        _logger = logger;
        _gitHubClientUtil = gitHubClientUtil;
        _httpClient = httpClient;
    }

    public async ValueTask Add(string owner, string name, Discussion discussion, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Adding discussion to repo ({owner}/{repo}) ...", owner, name);

        try
        {
            var url = $"repos/{owner}/{name}/discussions";

            using var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(JsonSerializer.Serialize(discussion), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();

            _logger.LogInformation("Discussion added successfully to repo ({owner}/{repo}).", owner, name);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to add discussion to repo ({owner}/{repo})", owner, name);
            throw;
        }
    }

    public async ValueTask<List<Discussion>> GetAllForOwner(string owner, string? state = null, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting all discussions for owner ({owner}) ...", owner);

        var client = await _gitHubClientUtil.Get(cancellationToken);
        var response = await client.Users[owner].Repos.GetAsync(cancellationToken: cancellationToken);
        var repositories = response?.ToList() ?? new List<MinimalRepository>();

        var hasDiscussionsFilter = repositories.Where(c => c.HasDiscussions == true);
        var allDiscussions = new List<Discussion>();

        foreach (var repo in hasDiscussionsFilter)
        {
            var discussions = await GetAll(owner, repo.Name, state, false, cancellationToken);

            if (discussions.Any())
            {
                allDiscussions.AddRange(discussions);
            }

            await Task.Delay(Random.Shared.Next(50, 200), cancellationToken);
        }

        return allDiscussions;
    }

    public async ValueTask<List<Discussion>> GetAll(string owner, string name, string? state = null, bool log = true, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting all discussions for repo ({owner}/{repo}) ...", owner, name);

        var allDiscussions = new List<Discussion>();
        var page = 1;
        var hasMore = true;

        while (hasMore && !cancellationToken.IsCancellationRequested)
        {
            var url = $"repos/{owner}/{name}/discussions?per_page=100&page={page}";
            using var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await _httpClient.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var discussions = JsonSerializer.Deserialize<List<Discussion>>(content);

            if (discussions?.Any() == true)
            {
                if (!string.IsNullOrEmpty(state))
                {
                    foreach (var discussion in discussions)
                    {
                        if (discussion.State == state)
                            allDiscussions.Add(discussion);
                    }
                }
                else
                {
                    allDiscussions.AddRange(discussions);
                }

                page++;
            }
            else
            {
                hasMore = false;
            }
        }

        if (log)
            _logger.LogInformation("Retrieved {Count} discussions from repo ({owner}/{repo}).", allDiscussions.Count, owner, name);

        return allDiscussions;
    }

    public async ValueTask DeleteAll(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting all discussions from repo ({owner}/{repo}) ...", owner, name);

        var discussions = await GetAll(owner, name, null, true, cancellationToken);

        foreach (var discussion in discussions)
        {
            await Delete(owner, name, discussion.Number, cancellationToken);
        }

        _logger.LogInformation("All discussions deleted from repo ({owner}/{repo}).", owner, name);
    }

    public async ValueTask Delete(string owner, string name, int discussionNumber, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting discussion #{discussionNumber} from repo ({owner}/{repo}) ...", discussionNumber, owner, name);

        try
        {
            var url = $"repos/{owner}/{name}/discussions/{discussionNumber}";

            using var request = new HttpRequestMessage(HttpMethod.Delete, url);
            var response = await _httpClient.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();

            _logger.LogInformation("Discussion #{discussionNumber} deleted successfully from repo ({owner}/{repo}).", discussionNumber, owner, name);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to delete discussion #{discussionNumber} from repo ({owner}/{repo})", discussionNumber, owner, name);
            throw;
        }
    }
}

public class Discussion
{
    public int Number { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public string? State { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? HtmlUrl { get; set; }
    public string? NodeId { get; set; }
    public SimpleUser? Author { get; set; }
    public int? CommentsCount { get; set; }
    public string? CommentsUrl { get; set; }
    public ReactionRollup? Reactions { get; set; }
} 