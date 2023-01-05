using Banking;
using EGovernment;
Government bjpObj=new Government();

TaxOperator itOperator=new TaxOperator(bjpObj.DeductIncomeTax);
TaxOperator proOperator=new TaxOperator(bjpObj.DeductProfessionalTax);

Account acct=new Account(60000);

acct.overBalance+=itOperator;
acct.overBalance+=proOperator;

Console.WriteLine("Enter Deposiite Amount");
double amount=Convert.ToDouble(Console.ReadLine());
acct.Deposite(amount);
Console.WriteLine("Before Paytax");
Console.WriteLine(acct);


acct.PayTax();
Console.WriteLine("After Paytax");
Console.WriteLine(acct);
