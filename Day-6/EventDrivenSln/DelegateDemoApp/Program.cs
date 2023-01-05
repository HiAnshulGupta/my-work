using Egovernance;
using Banking;

centralGovt bjp=new centralGovt();

// bjp.DeductIncometax();
// Console.WriteLine(bjp.DeductIncometax());
Taxoperation itOperation=new Taxoperation(bjp.DeductIncometax);
itOperation(1000);
Taxoperation ProOperation =new Taxoperation(bjp.Block);
Taxoperation PreOperation =new Taxoperation(bjp.Message);




Account acct123=new Account(15000);

acct123.OverBalance+=itOperation;
acct123.UnderBalance+=ProOperation;
acct123.LowBalance+=PreOperation;

Console.WriteLine("enter the amount");
double amount=double.Parse(Console.ReadLine());

// acct123.Deposit(amount);

// Console.WriteLine("Before Tax processing");
// Console.WriteLine(acct123);

// //performing action
// acct123.ProcessTax();
// Console.WriteLine("After Tax processing");
// Console.WriteLine(acct123);

acct123.Withdraw(amount);

Console.WriteLine("Before Tax processing");
Console.WriteLine(acct123);

//performing action
acct123.ProcessTax();
Console.WriteLine("After Tax processing");
Console.WriteLine(acct123);