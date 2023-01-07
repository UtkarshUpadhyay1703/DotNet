using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;

namespace Employee.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Employee(){
        return View();
    }
    public IActionResult EmployeeAdd(int Id, string Name, string desg, int sal){
        Console.WriteLine(Id+" "+Name+" "+desg+" "+sal);
        EmployeeManager.AddEmployee(new Employees( Id, Name, desg, sal));
        return Redirect("/home/EmployeeAdd");
    }
    public IActionResult EmployeeDisplay(){
        Console.WriteLine("Inside Emp Display");
        EmployeeManager.Display();
        return Redirect("/home");
    }
}