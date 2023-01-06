namespace BOL;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Employees
{
public int Empid{get;set;}
[Required]
public string Ename{get;set;}
public string designation{get;set;}
// public DateTime joindate{get;set;}
public Double basicSal{get;set;}

public Employees(){
    this.Empid=10;
    this.Ename="tarun";
    this.designation="Manager";
    // this.joindate="2000-03-17";
    this.basicSal=10101;
}
public Employees(int Empid,string  Ename,string designation,Double basicSal){
    this.Empid=Empid;
    this.Ename=Ename;
    this.designation=designation;
    // this.joindate=joindate;
    this.basicSal=basicSal;
}
// List<Employees> list =new List<Employees>();

// public void AddEmployee(int Empid,string  Ename,string designation,Double basicSal){
//     list.Add(new Employees(Empid,Ename,designation,basicSal));
// }
// public bool DeleteEmployee(int empid){
//     foreach(Employees e in list){
//         if(e.Empid==empid){
//             list.Remove(e);
//             return true;
//         }
//     }
//     return false;
// }
// public void Display(){
//     foreach(Employees e in list){
//         Console.WriteLine($"{e.Empid}");
//     }
// }
}
