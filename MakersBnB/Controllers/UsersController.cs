using MakersBnB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakersBnB.Controllers;
public class UsersController : Controller
{ 
    // lets you log message for debugging or error tracking
    private readonly ILogger<SpacesController> _logger;
    // Provides access to the database via the entity framework core
    private readonly MakersBnBDbContext _db;

    // ASP.NET automatically injects the logger and DB context, so that they can both be used in the class
    public UsersController(ILogger<SpacesController> logger, MakersBnBDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    //Create user index page that returns a view
    public IActionResult Index() 
    {
        return View();
    }
    // new method to create a new form, which is displayed in views/users/new.cshtml
    public IActionResult New()
    {
        return View();
    }
    // Create a Create method that takes a new submission as a POST "/Users" request
    // maps method to /users route
    [Route("/Users")]
    // Method only responds to post requests
    [HttpPost]
    // Binds form input to the users object
    public IActionResult Create(Users users)
    {
        // Adds the new item to the database
        _db.Users.Add(users);
        // Saves the new permanently
        _db.SaveChanges();
        return RedirectToAction("Spaces");
    }
// look at space controller and create methods in spacecontroller. Create tests such as getbylabel

// Controllers/UserController redirect to spaces when submitting form. Create test.

}