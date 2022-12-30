using Banking;
using Maths;
Console.WriteLine("Hello, World!");
Account acc1=new Account(5000);
acc1.Deposite(150);
Console.WriteLine(acc1.Balance);
acc1.Withdraw(50);
Console.WriteLine(acc1.Balance);
Account acc2=new Account(2000);
Account acc3=acc1+acc2;
Console.WriteLine(acc3.Balance);
Complex com1=new Complex(5,5);
Complex com2=new Complex(6,7);
Complex com3=com1+com2;
Console.WriteLine(com3.Real+"       "+com3.Imaginary);

var a=new{
    FirstName="Duggu",
    SecondName="Yadav"
};
Console.WriteLine(a.FirstName+"   "+a.SecondName);


