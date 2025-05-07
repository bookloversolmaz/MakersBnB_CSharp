using MakersBnB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakersBnB.Controllers;

public class SpacesController : Controller
{
    private readonly ILogger<SpacesController> _logger;
    private readonly MakersBnBDbContext _db;

    public SpacesController(ILogger<SpacesController> logger, MakersBnBDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        // _db.spaces reference to spaces dbset in db. .tolist executes query and returns items as a list.
        // Give me a list of all rows from the Spaces table and store them in a variable called spaces.
        var spaces = _db.Spaces.ToList();
        return View(spaces);
    }
    // new is the standard request for a for to create a new thing. The method below creates a new form, which is displayed in views/spaces/new
    public IActionResult New()
    {
        return View();
    }

    [Route("/Spaces")]
    [HttpPost]
    public IActionResult Create(Space space)
    {
        _db.Spaces.Add(space);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }
    // Get 
}
