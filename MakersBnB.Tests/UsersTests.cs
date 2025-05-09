namespace MakersBnB.Tests;

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
// This class inherits from the parent class page test, aka unittest1.
public class SignUpTests : PageTest
{
    [Test]
    public async Task UserIndexPageHasCorrectTitle()
    {
        //When users go to user page, they see a user heading
        await Page.GotoAsync("http://localhost:5163/users");
        await Expect(Page).ToHaveTitleAsync(new Regex("Users"));
    }
    [Test]
    public async Task UserPageIncludesUserHeading() 
    {
        await Page.GotoAsync("http://localhost:5163/users");
        await Expect(Page.GetByText("Users")).ToBeVisibleAsync();
    }
    // New or sign up page loads and contains User heading
    [Test]
    public async Task SignUpPageLoadingCorrectly()
    {
        await Page.GotoAsync("http://localhost:5163/users/new");
        await Expect(Page.GetByText("Complete the sign up form")).ToBeVisibleAsync();
    }
    //check that the form loads
    [Test]
    public async Task CheckThatTheFormLoads()
    {
        await Page.GotoAsync("http://localhost:5163/users/new");
        await Expect(Page.GetByRole(AriaRole.Form)).ToBeVisibleAsync();
    }

    // fill out the form: getbylabel types a value into the input field to mimic user action
    [Test]
    public async Task CheckThatTheCorrectLabelsAreDisplayedInForm()
    {
        await Page.GotoAsync("http://localhost:5163/users/new");
        await Page.GetByLabel("Username").FillAsync("DAVE");
    }
    
    // submit the form
    [Test]
    public async Task SubmitTheForm()
    {
        await Page.GotoAsync("http://localhost:5163/users/new");
        await Page.GetByRole(AriaRole.Button, new() {Name = "Submit"}).ClickAsync();
    }
    
}