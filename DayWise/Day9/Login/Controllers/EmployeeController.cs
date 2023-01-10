using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace Login.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult EmployeeRegister()
    {
        return View();
    }

    public IActionResult Serialize(string Name, string Email, string Password)
    {
        // List<Employee> list =new List<Employee>();
        string fileName = @"D:\Dot Net\HW\DotNet\DayWise\Day9\Login\Emp.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<Employee> jsonEmployee = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        jsonEmployee.Add(new Employee(Name, Email, Password));
        var options = new JsonSerializerOptions { IncludeFields = true };
        var Empjson = JsonSerializer.Serialize<List<Employee>>(jsonEmployee, options);
        System.IO.File.WriteAllText(fileName, Empjson);
        Console.WriteLine("Serialization done");
        return Redirect("/employee/Login");
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult ValidateEmployee(string Email, string Password)
    {
        Console.WriteLine(Email + "  " + Password);
        string fileName = @"D:\Dot Net\HW\DotNet\DayWise\Day9\Login\Emp.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<Employee> jsonEmployee = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        foreach (Employee emp in jsonEmployee)
        {
            Console.WriteLine("emp : " + emp);
            if (emp.Email == Email)
            {
                Console.WriteLine("emp : Email" + emp.Email);
                if (emp.Password == Password)
                {
                    Console.WriteLine("emp : Password" + emp.Password);
                    return Redirect("/home");
                    break;
                }
                return Redirect("/employee/Login");
                break;
            }
        }
        return Redirect("/employee/Login");
    }
}
