using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [AutoValidateAntiforgeryToken]
    public IActionResult Index()
    {
        string name  = "Yuri";
        return View();
    }

     public IActionResult Bamba()
    {
        string name  = "Yuri";
        return View();
    }

    [IgnoreAntiforgeryToken]
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
