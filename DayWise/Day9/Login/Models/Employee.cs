namespace Login.Models;
public class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Employee(String Name,String Email, String Password)
    {
        this.Name=Name;
        this.Email = Email;
        this.Password = Password;
    }

    public override string ToString()
    {
        return base.ToString() +"  "+Name+ "  " + Email + "  " + Password;
    }
}