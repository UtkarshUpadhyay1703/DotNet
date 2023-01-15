using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace RegisterEmp.Controllers;
using BOL;
using DAL;

[ApiController]
[Route("[controller]")]
public class RegisterEmpController : ControllerBase
{
    private readonly ILogger<RegisterEmpController> _logger;

    public RegisterEmpController(ILogger<RegisterEmpController> logger)
    {
        _logger = logger;
    }
    [HttpGet(Name = "GetEmployees")]
    [EnableCors()]
    public IEnumerable<Employee> Get(){
        List<Employee> allEmp=new List<Employee>();
        DBManager dbm=new DBManager();
        allEmp=dbm.GetAll();
        return allEmp;
    }
}