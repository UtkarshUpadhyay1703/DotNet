namespace Membership;
public static class AuthManager
{
    public static bool Validation(String email,String password){
        bool status=false;
        if(email=="utkarsh1703@gmail.com" && password=="jaihind"){
            status=true;
            Console.WriteLine(status);
            return status;
        }
        return false;
    }
    public static bool Register(string firstName,string lastName,string location,string email,string contactNumber){
        bool status=false;
        try{
            User newUser=new User();
            newUser.FirstName=firstName;
            newUser.LastName=lastName;
            newUser.Email=email;
            newUser.Location=location;
            newUser.ContactNumber=contactNumber;
            Console.WriteLine(newUser);
            status=true;
    }
    catch(Exception e){
        Console.WriteLine(e);
    }finally{
    }
                return status;
    }
}
