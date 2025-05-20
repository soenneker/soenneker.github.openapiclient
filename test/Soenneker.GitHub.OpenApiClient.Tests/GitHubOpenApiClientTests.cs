using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.GitHub.OpenApiClient.Tests;

[Collection("Collection")]
public class GitHubOpenApiClientTests : FixturedUnitTest
{
    public GitHubOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
