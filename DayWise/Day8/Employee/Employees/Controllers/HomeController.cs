using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employees.Models;
using Person;
using System.Text.Json;
using System.Collections.Generic;
namespace Employees.Controllers;

public class HomeController : Controller
{
    List<Employee> list=new List<Employee>();
    
    // list.Add(new Employee(1,"fghj","dfghj",5454));
    
    // list.Add(new Employee(Empid:1,Ename:"cgh",designation:"ghj",basicSal:456));
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult ValidateEmployee(int Id, string Name, string desg, int sal){
        Console.WriteLine(Id+" "+Name+" "+desg+" "+sal);
        list.Add(new Employee( Id, Name, desg, sal));
        // list.Add(new Employee( Empid:Id, Ename:Name, designation:desg, basicSal:sal));
        return Redirect("/home/DisplayEmployee");
    }
    public IActionResult DisplayEmployee(){
        Console.WriteLine("DisplayEmployee"+"  "+list.Count);
        foreach (Employee emp in list)
        {
            // Console.WriteLine("EmpId : "+emp.Empid+"Ename : "+emp.Ename+"Desg : "+emp.designation+"sal : "+emp.basicSal);
            Console.WriteLine(emp);
        }
        Console.WriteLine("DisplayEmployee End");
        return Redirect("/home");
    }
    public IActionResult Serialize(){
        var options=new JsonSerializerOptions{IncludeFields=true};
        var employeeJson=JsonSerializer.Serialize<list<Employee>>(list,options);
        string fileName=@"C:\Windows\System32\cmd.exe";
        File.WriteAllText(fileName,employeeJson);
        return Redirect("/home");
    }
    public IActionResult Deserializer(){
        string fileName=@"C:\Windows\System32\cmd.exe";
        string jsonString =File.ReadAllText(fileName);
        List<Employee> jsonEmp=JsonSerializer.Deserialize<List<Employee>>(jsonString);
        Console.WriteLine("\n Deserialize data from json file\n");
        foreach(Employee e in jsonEmp){
            Console.WriteLine(e.Empid + " " + e.Ename + " " + e.designation + " " + e.basicSal);
        }
        return Redirect("/home");
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult EmployeeAdd(){
        return View();
    }                             

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
