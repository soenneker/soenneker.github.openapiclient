using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient.Models;

namespace Soenneker.GitHub.OpenApiClient
{
    public class GitHubPackagesUtil
    {
        private readonly ILogger<GitHubPackagesUtil> _logger;
        private readonly IGitHubOpenApiClientUtil _gitHubClientUtil;
        private readonly int _maximumPerPage;

        public GitHubPackagesUtil(
            ILogger<GitHubPackagesUtil> logger,
            IGitHubOpenApiClientUtil gitHubClientUtil,
            int maximumPerPage = 100)
        {
            _logger = logger;
            _gitHubClientUtil = gitHubClientUtil;
            _maximumPerPage = maximumPerPage;
        }

        public async ValueTask<List<Package>> GetAllForUser(string owner, Package_package_type packageType, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Getting all packages for owner ({owner})...", owner);

            GitHubOpenApiClient client = await _gitHubClientUtil.Get(cancellationToken);

            var result = new List<Package>();
            var page = 1;

            while (true)
            {
                var packages = await client.Users[owner].Packages.GetAsync(
                    requestConfiguration => 
                    {
                        requestConfiguration.QueryParameters.PackageType = packageType.ToString().ToLower();
                        requestConfiguration.QueryParameters.Page = page;
                        requestConfiguration.QueryParameters.PerPage = _maximumPerPage;
                    }, 
                    cancellationToken);

                if (packages?.Count == 0)
                    break;

                _logger.LogDebug("Found {Count} packages", packages?.Count ?? 0);
                
                if (packages != null)
                {
                    result.AddRange(packages);
                }

                if (packages?.Count < _maximumPerPage)
                    break;

                page++;
            }

            return result;
        }
    }
} 