
using Alba;
using References.Api.Links;

namespace References.Tests.Links;

public class AddingALink
{
    [Fact]
    public async Task CanAddLink()
    {
        var linkToAdd = new LinkCreateRequest("https://www.github.com", "Github.com");

        var host = await AlbaHost.For<Program>();

        var postResponse = await host.Scenario(api =>
        {
            api.Post.Json(linkToAdd).ToUrl("/links");
            api.StatusCodeShouldBeOk();
        });

        Assert.NotNull(postResponse);

        


    }
}
