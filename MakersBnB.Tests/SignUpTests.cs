namespace MakersBnB.Tests;

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
// This class inherits from the parent class page test, aka unittest1.
public class SignUpTests : PageTest {
    [Test]
    public async Task SignUpFormLoads() 
    {
        //When users go to user page, they see a user heading
        await Page.GotoAsync("http://localhost:5163/Users");
        await Expect(Page).ToHaveTitleAsync(new Regex("Users"));
    }
 


}