[![](https://img.shields.io/nuget/v/soenneker.github.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.github.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.github.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.github.openapiclient/actions/workflows/codeql.yml)

# Soenneker.GitHub.OpenApiClient

A Kiota-generated .NET client for GitHub's REST API.

## Installation

```bash
dotnet add package Soenneker.GitHub.OpenApiClient
```

## Create a client

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.GitHub.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.github.com/")
};
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", githubToken);
httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
httpClient.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
httpClient.DefaultRequestHeaders.Add("User-Agent", "your-application-name");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new GitHubOpenApiClient(adapter);
```

The dedicated HTTP client supplies authentication and GitHub's required headers, so the Kiota adapter uses `AnonymousAuthenticationProvider` and does not add a second authorization value.

## Make a request

```csharp
var currentUser = await client.User.GetAsync(
    cancellationToken: cancellationToken);

var repository = await client.Repos["example-org"]["example-repository"]
    .GetAsync(cancellationToken: cancellationToken);
```

Request builders mirror GitHub's resource hierarchy. Path parameters are usually indexers, and endpoint methods accept request bodies, request-configuration callbacks, and cancellation tokens as described by the generated signatures.

The source is generated and its public models follow GitHub's OpenAPI description. Keep custom behavior and policy outside this package so regeneration does not overwrite it. `Soenneker.GitHub.ClientUtil` provides authenticated transport and cached construction for application services.
