namespace EGovernment;

    public delegate void TaxOperation(double amount);
public class Government{
    
    public void DeductIncomeTax(double amount){
        Console.WriteLine("25% will be deducted");
    }

    public void DeductProfessionalTax(double amount){
        Console.WriteLine("5% will be deducted");
    }
    public void DeductServiceTax(double amount){
        Console.WriteLine("2% will be deducted");
    }
}