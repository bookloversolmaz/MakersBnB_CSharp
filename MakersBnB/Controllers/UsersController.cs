using MakersBnB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakersBnB.Controllers;
public class UsersController : Controller
{
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

}