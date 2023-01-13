namespace BOL;
public class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}

    public Employee(int Id,string Name,string Email,string Password){
        this.Email=Email;
        this.Id=Id;
        this.Password=Password;
        this.Name=Name;
    }
    
}
