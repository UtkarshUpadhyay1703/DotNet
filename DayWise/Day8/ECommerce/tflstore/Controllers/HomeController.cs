using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;

namespace tflstore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public  IActionResult Login(){
        return View();
    }

    public IActionResult Validation(string Email, string Password){
        if(Email=="utkarsh1703@gmail.com" && Password=="utk"){
            Console.WriteLine("inside true Validation Controller");
            return Redirect("/Home/Welcome");
        }
            return View();
    }
    
    public IActionResult Registration(){
        return View();
    }

    public IActionResult Welcome(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
