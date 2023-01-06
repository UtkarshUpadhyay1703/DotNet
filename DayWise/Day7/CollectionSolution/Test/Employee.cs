namespace Person;
public class Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Desg{get;set;}
    public Employee(int Id,string Name,string Desg){
        this.Id=Id;
        this.Name=Name;
        this.Desg=Desg;
    }
    public override string ToString()
    {
        return base.ToString()+"Id : "+Id+"Name : "+Name+"Designation : "+Desg;
    }
}