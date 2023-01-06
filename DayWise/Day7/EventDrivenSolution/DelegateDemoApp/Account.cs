namespace Banking;
using EGovernment;
public class Account{
    public double Balance{set;get;}
    public event TaxOperation overBalance;

public Account(double amount){
    this.Balance=amount;
}

    public void Withdraw(double amount){
        this.Balance-=amount;
    }
    public void Deposite(double amount){
        this.Balance+=amount;
    }
    public override string ToString()
    {
            return this.ToString+"Balance = "+Balance;
    }
    public void payTax(){
        if(this.Balance>250000){
            overBalance(this.Balance);
        }
    }
}