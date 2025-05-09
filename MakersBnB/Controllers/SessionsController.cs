using MakersBnB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MakersBnB.Controllers;
// Use the submitted email to find a user in the database
// Compare the submitted password with the password of the user in our database
// If the user exists and the passwords match, authentication was successful
// And we will put the user's id in their session for later
// Then redirect to "/Spaces"
public class SessionsController : Controller {
    private readonly MakersBnBDbContext _db;

    public SessionsController(ILogger<SessionsController> logger, MakersBnBDbContext db)
    {
        _db = db;
    }
    public IActionResult New()
    {
        return View();
    }


    [Route("/Sessions")]
    [HttpPost]
    public IActionResult Create(string email, string password) {
         Console.WriteLine($"Login attempt with {email} / {password}");
        // ASP.NET automatically passes email and password as args (see above)

        // MakersBnBDbContext dbContext = new MakersBnBDbContext();

        // // using the submitted email to find a user in the database
        // Users? user = dbContext.Users.Where(user => user.Email == email).First();

        // The above makers code, didn't work, chtgpt provided the below, which works:
        // _db.Users: refers to the Users table in your database via your Entity Framework DbContext (_db)
        // arrow part searches db for first user where condition is true
        // FirstOrDefault() returns null if no match is found — so it’s safer than first which throws an error
        // Users? user: ? variable can be null, which is necessary because FirstOrDefault() might return no user.
        // Manually creating DbContext	EF Core expects this to be injected via constructor (you already had _db)
        // so don't need MakersBnBDbContext dbContext = new MakersBnBDbContext();
        // so code below finds the first user in the db whos email matches a submitted value
        Users? user = _db.Users.FirstOrDefault(u => u.Email == email);

        // checking if a user was found and that the passwords match
        // if(user != null && user.Password == password)
        // {
        // // putting the user's id in their session for later
        // HttpContext.Session.SetInt32("user_id", user.Id);
        // return new RedirectResult("/Spaces");
        // } else {
        // return new RedirectResult("/Sessions/New");
        // }

        if(user != null && user.Password == password)
        {
            HttpContext.Session.SetInt32("user_id", user.Id);
            return RedirectToAction("Spaces");
        } 
        else 
        {
            // return RedirectToAction("Sessions/New");
            return View("/Sessions/New");
        }

    }

}
