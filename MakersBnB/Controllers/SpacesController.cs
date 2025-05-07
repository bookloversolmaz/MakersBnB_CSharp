using MakersBnB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakersBnB.Controllers;

public class SpacesController : Controller
{
    private readonly ILogger<SpacesController> _logger;

    public SpacesController(ILogger<SpacesController> logger)
    {
        _logger = logger;
    }

    // will handle `GET "/Spaces"`
    public IActionResult Index()
    {
        // will try to find Spaces.cshtml in Views/Spaces or Views/Shared
        // Create an instance of Space with the required parameters
        Space listing1 = new Space("Flat", "Cosy flat in the middle of London", 2, 100);
        // Pass the instance to the ViewBag
        ViewBag.Listing1 = listing1;
        return View();
    }
    // controller code

}
