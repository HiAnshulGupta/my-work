namespace Banking;
using Egovernance;
public class Account{

    public event Taxoperation OverBalance;
    public event Taxoperation UnderBalance;
    public event Taxoperation LowBalance;

    

    public double Balance {get; set;}


    public Account(double Amount){
        this.Balance=Amount;
    }

    public void Deposit(double Amount){
        this.Balance+=Amount;
    }

    public void Withdraw(double Amount){
        this.Balance-=Amount;
    }

    public override string ToString()
    {
        return  "Current Balance ="+ this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance >=250000){
            //raise an event   
            OverBalance(this.Balance);    
        }
        else if(this.Balance<=5000){
            UnderBalance(this.Balance);
        }
        else if(this.Balance>5000 && this.Balance<10000){
           LowBalance(this.Balance);
        }


    }

    

}