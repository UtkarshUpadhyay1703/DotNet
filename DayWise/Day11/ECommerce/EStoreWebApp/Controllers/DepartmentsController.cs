using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class DepartmentsController : Controller
{
    private readonly ILogger<DepartmentsController> _logger;

    public DepartmentsController(ILogger<DepartmentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Department> allDepartments=new List<Department>();
        HRManager manager=new HRManager();
        allDepartments = manager.GetAllDepartments();
         this.ViewData["departments"]=allDepartments;
        return View();
    }
    
}