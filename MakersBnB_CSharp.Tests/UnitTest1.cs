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
        await Page.GotoAsync("http://localhost:5106");

        // expect the page title to contain "Index Page - MakersBnB"
        await Expect(Page).ToHaveTitleAsync(new Regex("Index Page - MakersBnB"));
    }
}
