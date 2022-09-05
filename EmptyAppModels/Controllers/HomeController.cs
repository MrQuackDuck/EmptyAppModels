using System.Text;
using EmptyAppModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyAppModels.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Person person)
    {
        if (ModelState.IsValid)
        {
            return View("Success", person);
        }
        else
        {
            return View();
        }
    }
}