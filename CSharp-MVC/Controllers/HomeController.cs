using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharp_MVC.Models;

namespace CSharp_MVC.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        HomeModel home = new HomeModel();
        home.Email = "jhonatas2004";
        home.Nome = "Jhonatas Oliveira da Silva";
        return View(home);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

