namespace MakersBnB.Tests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

public class Tests : PageTest
{
    // the following method is a test
    [Test]
    public async Task IndexpageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        // go to the MakersBnB Index page
        await Page.GotoAsync("http://localhost:5163");

        // expect the page title to contain "Index Page - MakersBnB"
        await Expect(Page).ToHaveTitleAsync(new Regex("Home Page - MakersBnB"));
    }

    [Test]
 public async Task HomePageIncludesWelcomeMessage() {
     await Page.GotoAsync("http://localhost:5163");

     await Expect(Page.GetByText("Welcome to MakersBnB!")).ToBeVisibleAsync();
    }

    [Test]
public async Task ReviewsOnHomepage() {
    await Page.GotoAsync("http://localhost:5163");
    var reviews = Page.Locator("li.review");
    await Expect(reviews).ToContainTextAsync(new string[] {"review 1", "review 2", "review 3"});
    }
    [Test]
public async Task PrivacyPageContainsAText() {
    await Page.GotoAsync("http://localhost:5163/Home/Privacy");
    await Expect(Page.GetByText("Pass the test")).ToBeVisibleAsync();
}

} 

