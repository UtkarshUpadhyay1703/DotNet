namespace Person;
public static class Employee{
    public int Empid{get;set;}
    public string Ename{get;set;}
    public string designation{get;set;}
    public Double basicSal{set;get;}
    public static Employee(int Empid,String Ename,String designation,Double basicSal){
        this.Empid=Empid;
        this.Ename=Ename;
        this.designation=designation;
        this.basicSal=basicSal;
    }
}