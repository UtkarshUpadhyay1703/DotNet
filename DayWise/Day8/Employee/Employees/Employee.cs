namespace Person;

public class Employee
{
    public int Empid { get; set; }
    public string Ename { get; set; }
    public string designation { get; set; }
    public double basicSal { get; set; }

    public Employee(int Empid, String Ename, String designation, Double basicSal)
    {
        this.Empid = Empid;
        this.Ename = Ename;
        this.designation = designation;
        this.basicSal = basicSal;
    }

    public override string ToString()
    {
        return base.ToString() + "  " + Empid + "  " + Ename + "  " + designation + "  " + basicSal;
    }
}
