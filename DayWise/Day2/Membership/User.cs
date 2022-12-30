namespace Membership;
public class User{
    private string firstName;
    public string FirstName{
        get{return firstName;}
        set{firstName=value;}
    }
    public string LastName{set; get;}
    public string Email{set; get;}
    public string ContactNumber{set; get;}
    public string Location{set; get;}
    public override string ToString(){
        string str=string.Format("{0},{1}, {2}, {3}, {4} ",FirstName,LastName,Email,ContactNumber,Location);
        return str;
    }
}