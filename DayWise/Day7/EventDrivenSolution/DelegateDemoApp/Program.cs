using Banking;
using EGovernment;
using System.Threading;
Government bjpGov=new Government();

TaxOperation itOperator=new TaxOperation(bjpGov.DeductIncomeTax);
TaxOperation proOperator=new TaxOperation(bjpGov.DeductProfessionalTax);

Thread primaryThread=Thread.CurrentThread;
Console.WriteLine("Thread = "+ primaryThread.ManagedThreadId);

// Account acct=new Account(5414);

// acct.overBalance+=itOperator;
// acct.overBalance+=proOperator;

// Console.WriteLine("Enter the amount");
// acct.Deposite(double.Parse(Console.ReadLine()));
// Console.WriteLine("Before Paytax");
// Console.WriteLine(acct);

// Console.WriteLine("After PayTax");
// acct.payTax();
// Console.WriteLine(acct);


