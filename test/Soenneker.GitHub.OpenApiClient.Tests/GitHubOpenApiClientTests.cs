using Soenneker.Tests.HostedUnit;

namespace Soenneker.GitHub.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class GitHubOpenApiClientTests : HostedUnitTest
{
    public GitHubOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
