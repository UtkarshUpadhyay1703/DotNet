namespace Banking;
public class Account{
    private float balance;

    public Account(float balance){
        this.balance=balance;
    }
    public Account(){
        this.balance=5000;
    }
    public float Balance{
        get{return this.balance;}
        set{this.balance=value;}
    }
    public void Deposite(float amount){
        this.balance=this.balance+amount;
    }
    public void Withdraw(float amount){
        if(amount<=0 && balance<amount) throw new Exception("Invalid amount");
        this.balance=this.balance-amount;
    }
    public static Account operator+ (Account a1,Account a2){
        Account temp=new Account();
        temp.balance=a1.balance+a2.balance;
        return temp;
    }

}