namespace Banking;
using EGovernment;
public class Account{
    public event TaxOperator overBalance;
    private double Balance{set;get;}
    public Account(double balance){
        this.Balance=balance;
    }
    public void Deposite(double amount){
        Balance+=amount;
    }
    public void Withdraw(double amount){
        Balance-=amount;
    }

    public override string ToString(){
        return this.ToString() + "Balance : "+this.Balance;
    }
    public void PayTax(){
        if(this.Balance>=250000){
            overBalance(this.Balance);
        }
    }
}