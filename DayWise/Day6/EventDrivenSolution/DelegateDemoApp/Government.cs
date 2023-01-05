namespace EGovernment;
public delegate void TaxOperator(double amount);
public class Government{

    public void DeductIncomeTax(double amount){
        Console.WriteLine("50% Income tax");
    }
    public void DeductServiceTax(double amount){
        Console.WriteLine("10% Income tax");
    }
    public void DeductProfessionalTax(double amount){
        Console.WriteLine("5% Income tax");
    }
}