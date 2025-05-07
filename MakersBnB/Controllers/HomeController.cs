// in Controllers/HomeController.cs

// some imports
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MakersBnB.Models;

// a namespace declaration
namespace MakersBnB.Controllers;

// the HomeController class inherits from the Controller class
// this means it can do everything the Controller class can do
// plus whatever is defined in the HomeController class
public class HomeController : Controller
{
    // ths is just for logging
    private readonly ILogger<HomeController> _logger;

    // the constructor
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // `GET "/"` and `GET "/Home"` are handled by this method 
    public IActionResult Index()
    {
        // ASP.NET will default to using a template with the same name
        // as the method (Index.cshtml)
        ViewBag.Names = new string[2] {"trevor", "pauline"};
        return View();
    }

    // `GET "/Home/Privacy"` is handled by this method
    public IActionResult Privacy()
    {
        // ASP.NET will default to using a template with the same name
        // as the method (Privacy.cshtml)
        return View();
    }

    // `GET "/Home/Error"` is handled by this method
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        // ASP.NET will default to using a template with the same name
        // as the method (Error.cshtml)
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Team()
    {
      return View();
    }
    public IActionResult ContactUs() 
    {
        ViewBag.ContactUs = new string[1] {"fakeaddress@gmail.com"};
        return View();
    }

}
