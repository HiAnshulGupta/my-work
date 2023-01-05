namespace Egovernance;


public delegate void Taxoperation(double amount);
public class centralGovt{

    public void DeductIncometax(double amount){    
        Console.WriteLine("15% tax will be duducted");
    }
    public void DeductServicetax(double amount){
        Console.WriteLine("12% tax will be duducted");
    }

    public void DeductProfessionaltax(double amount){
        Console.WriteLine("10% tax will be duducted");
    }

    public void Block(double amount){
        Console.WriteLine("Your Account is blocked");
    }

    public void Message(double amount){
        Console.WriteLine("Sms has been Sent");
    }
     public void Email(double amount){
        Console.WriteLine("Email has been Sent");
    }

}