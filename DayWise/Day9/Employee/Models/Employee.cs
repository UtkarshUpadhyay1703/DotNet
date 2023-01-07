namespace Employee.Models;

public class Employees
{
    public int Empid { get; set; }
    public string Ename { get; set; }
    public string designation { get; set; }
    public double basicSal { get; set; }

    public Employees(int Empid, String Ename, String designation, Double basicSal)
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
