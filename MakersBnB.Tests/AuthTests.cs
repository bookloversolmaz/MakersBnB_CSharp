namespace MakersBnB.Tests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

public class AuthTests : PageTest
{
    [Test]
    public async Task SigningInWithCorrectCredentials()
    {
        // Sign up: create a user
        await Page.GotoAsync("http://localhost:5163/Users/New");
        await Page.GetByLabel("Username").FillAsync("username");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByLabel("Password").FillAsync("secret");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();

        // Sign in
        await Page.GotoAsync("http://localhost:5163/Sessions/New");
        await Page.GetByLabel("Email").FillAsync("email@email.com");
        await Page.GetByLabel("Password").FillAsync("secret");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();

        // Confirm redirect to Spaces page or some success condition
        await Expect(Page).ToHaveURLAsync(new Regex(".*/Spaces"));
        // Or: await Expect(Page).ToHaveTitleAsync(new Regex("Spaces"));
    }

    // a feature test for when authentication fails
    // (passwords don't match or user cannot be found)
[Test]
public async Task ShowsErrorOrRedirectsWhenAuthenticationFails()
{
    // Go to the login (sessions/new) page
    await Page.GotoAsync("http://localhost:5163/Sessions/New");

    // Fill in email and incorrect password
    await Page.GetByLabel("Email").FillAsync("nonexistent@example.com");
    // await Expect(Page.Locator("input[name='email']")).ToBeVisibleAsync();
    await Page.GetByLabel("Password").FillAsync("wrongpassword");

    // Submit the form
    await Page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();

    await Expect(Page.GetByLabel("Email")).ToBeVisibleAsync();
    }

}