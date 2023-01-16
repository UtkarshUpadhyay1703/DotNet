using Microsoft.AspNetCore.Mvc;
using BOL;
using DAL;
using Microsoft.AspNetCore.Cors;
namespace NishantCoder.Controllers;

[ApiController]
[Route("[controller]")]
public class NishantController : ControllerBase
{
    private readonly ILogger<NishantController> _logger;

    public NishantController(ILogger<NishantController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetNishant")]
        public IEnumerable<Nishant> Get()
    {
        List<Nishant> AllNishant=new List<Nishant>();
        DBManager dbm=new DBManager();
        AllNishant=dbm.GetAll();
        return AllNishant;
    }

    [HttpGet]
    [Route ("{id:}")]
    public Nishant GetById([FromRoute] int id){
        Nishant nishant=new Nishant();
        DBManager dbm=new DBManager();
        nishant=dbm.GetById(id);
        return nishant;
    }

    [HttpPost]
    public void GetNishant(Nishant nishant){
        DBManager dbm=new DBManager();
        dbm.InsertNishant(nishant);
    }
    [HttpDelete]
    [Route ("{id:}")]
    public void DeleteNishant(int id){
        DBManager dbm=new DBManager();
        dbm.DeleteNishant(id);
    }
    [HttpPut]
    [Route ("{id:}")]
    public void UpdateNishant(int id,Nishant nishant){
        DBManager dbm=new DBManager();
        dbm.UpdateNishant(id,nishant);
    }
}
