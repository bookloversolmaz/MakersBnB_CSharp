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
        return View();
    }
    // controller code

}
