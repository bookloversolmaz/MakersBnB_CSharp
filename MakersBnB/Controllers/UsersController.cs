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


}