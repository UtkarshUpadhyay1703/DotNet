using Membership;
Console.WriteLine("Enter email id and Password");
string email=Console.ReadLine();
string password=Console.ReadLine();
if(AuthManager.Validation(email,password)){
    Console.WriteLine("Enter in this order firstName,lastName,location,email1,contactNumber ");
    string firstName=Console.ReadLine();
    string lastName=Console.ReadLine();
    string location=Console.ReadLine();
    string email1=Console.ReadLine();
    string contactNumber=Console.ReadLine();
    AuthManager.Register(firstName,lastName,location,email1,contactNumber);
}else{
    Console.WriteLine("Not valid user");
}